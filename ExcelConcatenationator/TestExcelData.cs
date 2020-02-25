using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExcelConcatenationator
{
    class TestExcelData
    {
        [DisplayName("File Name")]
        public string fileName { get; set; }

        [DisplayName("Date Created")]
        public DateTime dateCreated { get; set; }

        [DisplayName("Date Last Saved")]
        public DateTime dateLastSaved { get; set; }

        [DisplayName("Column 1")]
        public string column1 { get; set; }

        [DisplayName("Column 2")]
        public string column2 { get; set; }

        [DisplayName("Column 3")]
        public string column3 { get; set; }

        [DisplayName("Column 4")]
        public string column4 { get; set; }

        [DisplayName("Column 5")]
        public string column5 { get; set; }


        public override string ToString()
        {
            return string.Join(",", fileName, dateCreated.ToShortDateString(), dateLastSaved.ToShortDateString(), column1, column2, column3, column4, column5);
        }

        // Constructor
        public TestExcelData()
        {
            dateCreated = DateTime.Now;
            dateLastSaved = DateTime.Now;
        }

        public TestExcelData(string fileName, DateTime dateCreated, DateTime dateLastSaved, string column1, string column2, string column3, string column4, string column5)
        {
            this.fileName = fileName;
            this.dateCreated = dateCreated;
            this.dateLastSaved = dateLastSaved;
            this.column1 = column1;
            this.column2 = column2;
            this.column3 = column3;
            this.column4 = column4;
            this.column5 = column5;
        }

        public static string[] GetPropertyDisplayNames()
        {
            var header = new TestExcelData();
            List<string> displayNames = new List<string>();

            displayNames.Add(typeof(TestExcelData).GetProperty("fileName").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("dateCreated").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("dateLastSaved").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("column1").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("column2").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("column3").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("column4").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);
            displayNames.Add(typeof(TestExcelData).GetProperty("column5").GetCustomAttributes(typeof(DisplayNameAttribute)).Cast<DisplayNameAttribute>().Single().DisplayName);

            return displayNames.ToArray();
        }
    }
}
