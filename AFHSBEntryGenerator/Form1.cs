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
            PopulateTextArea(AddTranslations(GetRows()));
        }

        public List<AFHSBEntry> GetRows()
        {
            var data = new List<AFHSBEntry>();

            using (var stream = File.Open(txt_Mappings.Text + "\\CTFN_Mapping.xlsx", FileMode.Open, FileAccess.Read))
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

        public List<AFHSBEntry> AddTranslations(List<AFHSBEntry> data)
        {
            using (var stream = File.Open(txt_Mappings.Text + "\\Translations.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read() && reader.GetString(0) != null)
                    {
                        int index = SearchListForAFHSBCTFN(data, reader.GetString(0));
                        if (index != -1)
                        {
                            var tempEntry = new AFHSBEntryTranslateNeeded(data[index]);

                            string[] EDCValues = reader.GetString(3).Split(',');
                            string[] AFHSBValues = reader.GetString(2).Split(',');

                            for (int i = 0; i < EDCValues.Length; i++)
                            {
                                tempEntry.ApplicationValueWithAFHSBValue.Add((EDCValues[i], AFHSBValues[i]));
                            }
                            data[index] = tempEntry;
                        }
                    }
                }
            }

            return data;
        }

        public void PopulateTextArea(List<AFHSBEntry> data)
        {
            using (var fileStream = new FileStream(txt_Mappings.Text + "\\AFHSBEntries.txt", FileMode.Append))
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

        public int SearchListForAFHSBCTFN(List<AFHSBEntry> list, string ctfn)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                if (string.Equals(ctfn, list[i].AFHSBCrossTabFieldName))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
