using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using CsvHelper;
using System.Globalization;

namespace ExcelConcatenationator
{
    public partial class Form1 : Form
    {
        public const string SEARCH_PATTERN = "Book*.xlsx";

        public Form1()
        {
            InitializeComponent();
        }

        #region events
        private void btn_AddPath_Click(object sender, EventArgs e)
        {
            if(IsPathValid(txt_Path.Text))
                listBox_Paths.Items.Add(txt_Path.Text);
            else
                MessageBox.Show("Invalid path");
        }

        private void btn_RemovePath_Click(object sender, EventArgs e)
        {
            listBox_Paths.Items.Remove(listBox_Paths.SelectedItem);
        }

        private void btn_StreamWrite_Click(object sender, EventArgs e)
        {
            if (IsPathValid(txt_Destination.Text.Substring(0, txt_Destination.Text.LastIndexOf("\\"))))
                listBox_Paths.Items.Add(txt_Destination.Text);
            else
                MessageBox.Show("Invalid destination path");

            List<string> excelList = new List<string>();

            foreach (var item in listBox_Paths.Items)
            {
                excelList.AddRange(GetExcelPaths(item.ToString()));
            }

            WriteToStream(excelList);
        }

        private void btn_ToStringOverride_Click(object sender, EventArgs e)
        {
            if (!IsPathValid(txt_Destination.Text.Substring(0, txt_Destination.Text.LastIndexOf("\\") + 1)))
            {
                MessageBox.Show("Invalid destination path");
                return;
            }

            List<string> excelList = new List<string>();

            foreach (var item in listBox_Paths.Items)
            {
                excelList.AddRange(GetExcelPaths(item.ToString()));
            }

            WriteToStreamWithOverride(GetAllExcelData(excelList));
        }
        private void btn_CsvHelper_Click(object sender, EventArgs e)
        {
            if (!IsPathValid(txt_Destination.Text.Substring(0, txt_Destination.Text.LastIndexOf("\\"))))
            {
                MessageBox.Show("Invalid destination path");
                return;
            }

            List<string> excelList = new List<string>();

            foreach (var item in listBox_Paths.Items)
            {
                excelList.AddRange(GetExcelPaths(item.ToString()));
            }

            UseCsvHelper(GetAllExcelData(excelList));
        }

        #endregion

        private List<string> GetExcelPaths(string path)
        {
            return Directory.GetFiles(path, SEARCH_PATTERN).ToList<string>();
        }

        private void WriteToStream(List<string> paths)
        {
            var csv = new StringBuilder();
            foreach (var path in paths)
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        if (paths.IndexOf(path) == 0)
                        {
                            reader.Read();
                            csv.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}\r\n", "File Name", "Created Date", "Last Save Date", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        }
                        else
                            reader.Read();

                        while (reader.Read())
                        {
                            csv.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}\r\n", path.Substring(path.LastIndexOf("\\") + 1), File.GetCreationTime(path).ToShortDateString(), File.GetLastWriteTime(path).ToShortDateString(), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        }
                    }
                }

            }

            using (var fileStream = new FileStream(txt_Destination.Text, FileMode.Append))
            {
                using (var strmWrtr = new StreamWriter(fileStream))
                {
                    strmWrtr.Write(csv.ToString());
                }
            }
        }

        private bool IsPathValid(string path)
        {
            return Directory.Exists(path);
        }

        private List<TestExcelData> GetAllExcelData(List<string> paths)
        {
            List<TestExcelData> data = new List<TestExcelData>();

            foreach (var path in paths)
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        reader.Read(); //-- Skip the header row

                        while (reader.Read())
                        {
                            data.Add(new TestExcelData(path.Substring(path.LastIndexOf("\\") + 1), File.GetCreationTime(path), File.GetLastWriteTime(path), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                        }
                    }
                }

            }
            return data;
        }

        private void WriteToStreamWithOverride(List<TestExcelData> data)
        {
            using (var fileStream = new FileStream(txt_Destination.Text, FileMode.Append))
            {
                using (var strmWrtr = new StreamWriter(fileStream))
                {
                    strmWrtr.WriteLine(string.Join(",", TestExcelData.GetPropertyDisplayNames())); //-- Headers

                    foreach (var item in data)
                    {
                        strmWrtr.WriteLine(item);
                    }

                }
            }
        }

        private void UseCsvHelper(List<TestExcelData> data)
        {
            using(var writer = new StreamWriter(txt_Destination.Text))
            using(var csvWrtr = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWrtr.WriteRecords(data);
            }
        }
    }
}
