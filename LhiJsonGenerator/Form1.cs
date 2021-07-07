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

using ExcelDataReader;
using Newtonsoft.Json;

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
            LHIEntry lhi = GetRows(txt_PathToExcel.Text);

            txt_JsonOutput.Text = JsonConvert.SerializeObject(lhi);
        }

        public LHIEntry GetRows(string path)
        {
            var data = new LHIEntry();

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read() && reader.GetString(0) != null)
                    {
                        LHIField entry = new LHIField();

                        entry.lhiCFName = reader.GetString(0);
                        entry.edhaCFName = reader.GetString(1);

                        if (!string.IsNullOrEmpty(reader.GetString(5)))
                            entry.NeedsFurtherEvaluation = true;

                        //-- Value type/mapping
                        if (reader.GetString(2) == "text")
                        {
                            entry.edhaValueDataType = "string";
                            entry.lhiValueDataType = "string";
                            entry.useValueAsIs = true;
                        }
                        else if (reader.GetString(2) == "guid")
                        {
                            entry.edhaValueDataType = "Guid";
                            entry.lhiValueDataType = "Guid";
                            entry.useValueAsIs = true;
                        }
                        else if (reader.GetString(2) == "date")
                        {
                            entry.edhaValueDataType = "DateTime";
                            entry.lhiValueDataType = "DateTime";
                            entry.useValueAsIs = true;
                        }
                        else if (reader.GetString(2) == "radio")
                        {
                            entry.edhaValueDataType = "string";
                            entry.lhiValueDataType = "string";
                            if (reader.GetString(3) == reader.GetString(4))
                                entry.useValueAsIs = true;

                            entry.valueMapping = GetValueMapping(reader.GetString(3).Split(','), reader.GetString(4).Split(','));
                        }

                        data.Fields.Add(entry);
                    }
                }
            }
            return data;
        }

        public Dictionary<string, string> GetValueMapping(string[] lhiValues, string[] edhaValues)
        {
            if (lhiValues.Length != edhaValues.Length)
            {
                var error = new Dictionary<string, string>();
                error.Add("error mapping values", "error mapping values");
                return error;
            }

            var mapping = new Dictionary<string, string>();

            for(int i = 0; i < edhaValues.Length; i++)
            {
                mapping.Add(edhaValues[i], lhiValues[i]);
            }

            return mapping;
        }
    }
}
