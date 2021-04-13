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

namespace PHA_AFHSB_ValidValuesJSON
{
    public partial class frm_ValidValuesAsJSON : Form
    {
        public frm_ValidValuesAsJSON()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {

        }

        public List<ValidValuesProfile> GetRows()
        {
            var data = new List<ValidValuesProfile>();

            using (var stream = File.Open(txt_Path.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    reader.Read(); //-- Skip the header row

                    while (reader.Read() && reader.GetString(0) != null)
                    {
                        ValidValuesProfile entry = new ValidValuesProfile();
                        bool exists = false;

                        foreach (var item in data)
                        {
                            if (reader.GetString(0) == item.PhaCtfn)
                            {
                                exists = true;
                                item.ValueType = reader.GetString(2);
                                item.PhaValidValues.Add(reader.GetString(1));
                            }

                            if (!exists)
                                data.Add(new ValidValuesProfile(reader.GetString(0), reader.GetString(2), reader.GetString(1)));
                        }

                        entry.PhaCtfn = reader.GetString(0);
                        entry.AfhsbCtfn = reader.GetString(2);

                        data.Add(entry);
                    }
                }
            }
            return data;
        }
    }
}
