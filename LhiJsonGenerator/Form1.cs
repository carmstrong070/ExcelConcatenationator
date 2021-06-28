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

namespace LhiJsonGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {

        }

        public LHIEntry GetRows()
        {
            var data = new LHIEntry();

            using (var stream = File.Open(txt_PathToExcel.Text + "\\CTFN_Mapping.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read() && reader.GetString(0) != null)
                    {
                        LHIField entry = new LHIField();

                        entry.lhiCFName = reader.GetString(0);
                        entry.edhaCFName = reader.GetString(1);


                        if (reader.GetString(2) == "TEXT FIELD")
                        {
                            entry.edhaValueDataType = "string";
                            entry.lhiValueDataType = "string";
                            entry.useValueAsIs = true;
                        }

                        data.Fields.Add(entry);
                    }
                }
            }
            return data;
        }
    }
}
