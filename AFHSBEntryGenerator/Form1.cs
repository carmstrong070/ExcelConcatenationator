using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFHSBEntryGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            PopulateTextArea(GetRows());
        }

        public List<AFHSBEntry> GetRows()
        {
            var data = new List<AFHSBEntry>();

            string path = txt_Path.Text;

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read() && reader.GetString(0) != null)
                    {
                        AFHSBEntry entry = new AFHSBEntry();

                        entry.AFHSBCrossTabFieldName = reader.GetString(0);
                        entry.CrossTabFieldName = reader.GetString(2);
                        entry.Ordinal = (int)reader.GetDouble(7);
                        entry.AFHSBOutputLength = (int)reader.GetDouble(1);

                        //-- If first entry then start index is 0, else calculate based on last entry
                        entry.StartIndex = (data.Count == 0) ? 0 : data.Last().StartIndex + data.Last().AFHSBOutputLength;

                        data.Add(entry);
                    }
                }
            }
            return data;
        }

        public void PopulateTextArea(List<AFHSBEntry> data)
        {
            //foreach (var item in data)
            //{
            //    txt_Output.Text += item.ToString() + "\n";
            //}
            using (var fileStream = new FileStream("C:\\temp\\test.txt", FileMode.Append))
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
