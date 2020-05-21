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
        public Form1()
        {
            InitializeComponent();
        }

        #region events
        private void btn_StaticLabels_Click(object sender, EventArgs e)
        {
            if (!IsPathValid(txt_Destination.Text.Substring(0, txt_Destination.Text.LastIndexOf("\\"))))
            {
                MessageBox.Show("Invalid destination path");
                return;
            }

            var data = GetAllExcelData(txt_Path.Text);

            string method = "";

            for (int i = 0; i < data.Count; i++)
            {
                method += "internal static string " + data[i].CTFN + "_StaticLabel(){ \n \t return " + "\"" + data[i].QuestionText + "\";" + "\n } \n \n";
            }

            System.IO.File.WriteAllText(txt_Destination.Text, method);

            MessageBox.Show("Static labels generated successfully.");
        }

        #endregion

        private bool IsPathValid(string path)
        {
            return Directory.Exists(path);
        }

        /// <summary>
        /// Gets all rows of excel documents given a list of paths
        /// </summary>
        /// <param name="paths">List of paths to excel documents</param>
        /// <returns>List of TestExcelData</returns>
        private List<AHLTAEntry> GetAllExcelData(string path)
        {
            List<AHLTAEntry> data = new List<AHLTAEntry>();

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    for (int i = 0; i < Convert.ToInt32(txt_Sheet.Text != "" ? txt_Sheet.Text : "0"); i++)
                    {
                        if (i > 0 ) reader.NextResult(); //-- Skip sheet
                    }

                    reader.Read();//-- Skip the header row

                        //-- Add each row to List as a new object
                        while (reader.Read() && reader.GetString(0) != "")
                        {
                            var entry = new AHLTAEntry();

                            entry.QuestionIdentifier = reader.GetString(0);
                            entry.CTFN = reader.GetString(1);
                            entry.QuestionText = reader.GetString(2);
                            //entry.TranslateMethod = reader.GetString(3);
                            //entry.NeedsNewMethod = reader.GetString(4) != "";

                            data.Add(entry);
                        }
                }                   
            }
            return data;
        }

        private void btn_GenerateSegments_Click(object sender, EventArgs e)
        {
            if (!IsPathValid(txt_Destination.Text.Substring(0, txt_Destination.Text.LastIndexOf("\\"))))
            {
                MessageBox.Show("Invalid destination path");
                return;
            }

            WriteToFile(GetAllExcelData(txt_Path.Text));

            MessageBox.Show("Segments generated successfully.");
        }

        internal void WriteToFile(List<AHLTAEntry> data)
        {
            using (var fileStream = new FileStream(txt_Destination.Text, FileMode.Append))
            {
                using (var strmWrtr = new StreamWriter(fileStream))
                {
                    foreach (var item in data)
                    {
                        strmWrtr.WriteLine(item);
                    }
                }
            }
        }

    }
}
