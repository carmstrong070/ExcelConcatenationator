using AirmenFSCTableGenerator;
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

namespace AirmenFSCGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GenerateHtml_Click(object sender, EventArgs e)
        {
            WriteHTMLToFile(GetRows());
        }

        private void btn_GenerateCodeBehindBehavior_Click(object sender, EventArgs e)
        {
            WriteInitialControlStateToFile(GetRows());
        }

        private void btn_GenerateApplyValues_Click(object sender, EventArgs e)
        {
            WriteInitialControlStateToFile(GetRows());
        }

        public List<AirmenFscEntry> GetRows()
        {
            var data = new List<AirmenFscEntry>();

            using (var stream = File.Open(txt_PathToExcel.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read())
                    {
                        if (!string.IsNullOrEmpty(reader.GetString(6)))
                        {
                            AirmenFscEntry entry = new AirmenFscEntry();

                            entry.SffpNumber = (int)reader.GetDouble(0);
                            entry.SffpCtfn = reader.GetString(1);

                            data.Add(entry);
                        }
                    }
                }
            }
            return data;
        }

        public void WriteHTMLToFile(List<AirmenFscEntry> data)
        {
            using (var fileStream = new FileStream("C:\\Temp\\AirmenHTMLGeneration.txt", FileMode.Append))
            {
                using (var strmWrtr = new StreamWriter(fileStream))
                {
                    foreach (var item in data)
                    {
                        strmWrtr.WriteLine(item.ToStringHtml());
                    }
                }
            }
        }

        public void WriteInitialControlStateToFile(List<AirmenFscEntry> data)
        {
            using (var fileStream = new FileStream("C:\\Temp\\AirmenInitialControlStateGeneration.txt", FileMode.Append))
            {
                using (var strmWrtr = new StreamWriter(fileStream))
                {
                    foreach (var item in data)
                    {
                        strmWrtr.WriteLine(item.ToStringInitialControlState());
                    }
                }
            }
        }
    }
}
