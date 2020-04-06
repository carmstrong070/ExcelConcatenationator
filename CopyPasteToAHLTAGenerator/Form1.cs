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

namespace CopyPasteToAHLTAGenerator
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
            if (IsPathValid(txt_Path.Text))
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

            SuccessMessage();
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

            SuccessMessage();
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

            SuccessMessage();
        }

        #endregion

        /// <summary>
        /// Gets all documents in a folder that match the Search Pattern
        /// </summary>
        /// <param name="path">Path to search in</param>
        /// <returns></returns>
        private List<string> GetExcelPaths(string path)
        {
            return Directory.GetFiles(path, SEARCH_PATTERN).ToList<string>();
        }

        /// <summary>
        /// Concatenates all rows of provided excel documents and writes them to a csv
        /// </summary>
        /// <param name="paths">List of paths to excel documents</param>
        private void WriteToStream(List<string> paths)
        {
            var csv = new StringBuilder();
            foreach (var path in paths)
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        //-- If it's the first excel sheet, take the header rows. Otherwise, skip
                        if (paths.IndexOf(path) == 0)
                        {
                            reader.Read();
                            csv.AppendFormat("{0},{1},{2},{3},{4},{5},{6},{7}\r\n", "File Name", "Created Date", "Last Save Date", reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                        }
                        else
                            reader.NextResult();

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

        /// <summary>
        /// Gets all rows of excel documents given a list of paths
        /// </summary>
        /// <param name="paths">List of paths to excel documents</param>
        /// <returns>List of TestExcelData</returns>
        private List<TestExcelData> GetAllExcelData(List<string> paths)
        {
            List<TestExcelData> data = new List<TestExcelData>();

            foreach (var path in paths)
            {
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        //reader.NextResult(); //-- Skip the header row

                        //-- Add each row to List as a new object
                        while (reader.Read())
                        {
                            var testData = new TestExcelData();
                            testData.column1 = reader.GetString(1);
                            testData.column2 = reader.GetString(2);                          

                            data.Add(testData);
                        }
                    }                   
                }
            }

            string method = "";

            for(int i = 0; i < data.Count; i++)
            {
                method += "internal static string " + data[i].column1 + "_StaticLabel(){ \n \t return " + "\"" + data[i].column2 + "\";" + "\n } \n \n";
            }
            

            System.IO.File.WriteAllText(@"C:\Users\casey\OneDrive\Desktop\WriteLines.txt", method);

            return data;
        }

        /// <summary>
        /// Uses overridden .ToString() for TestExcelData to write a list of objects to a csv
        /// </summary>
        /// <param name="data"></param>
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


        /// <summary>
        /// Uses CsvHelper to write a list of objects to a csv
        /// </summary>
        /// <param name="data"></param>
        private void UseCsvHelper(List<TestExcelData> data)
        {
            using (var writer = new StreamWriter(txt_Destination.Text))
            using (var csvWrtr = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                //-- Write headers for csv file
                foreach (string header in TestExcelData.GetPropertyDisplayNames())
                {
                    csvWrtr.WriteField(header);
                }
                csvWrtr.NextRecord();
                csvWrtr.Configuration.HasHeaderRecord = false;
                csvWrtr.WriteRecords(data);
            }
        }

        private void SuccessMessage()
        {
            MessageBox.Show("Excel documents concatenated successfully.");
        }
    }
}
