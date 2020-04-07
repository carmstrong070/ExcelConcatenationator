using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFHSBEntryGenerator
{
    public class AFHSBEntry
    {
        /// <summary>
        /// CTFN in Record Layout
        /// </summary>
        public string AFHSBCrossTabFieldName { get; set; }

        /// <summary>
        /// Application CTFN
        /// </summary>
        public string CrossTabFieldName { get; set; }

        public int StartIndex { get; set; }

        public int EndIndex => StartIndex + (AFHSBOutputLength - 1);

        public int AFHSBOutputLength { get; set; }

        public int Ordinal { get; set; }

        public bool CanHaveNullValue { get; set; } = true;

        // Constructors
        public AFHSBEntry()
        {
        }

        public AFHSBEntry(string AFHSBCTFN, string AppCTFN, int startIndex, int length, int ordinal, bool nullable = true)
        {
            this.AFHSBCrossTabFieldName = AFHSBCTFN;
            this.CrossTabFieldName = AppCTFN;
            this.StartIndex = startIndex;
            this.AFHSBOutputLength = length;
            this.Ordinal = ordinal;
            this.CanHaveNullValue = nullable;
        }
        public override string ToString()
        {
            return string.Format(@"new AFHSBEntry(){{ AFHSBCrossTabFieldName = ""{0}"", StartIndex = {1}, AFHSBOutputLength = {2}, CrossTabFieldName = ""{3}"", Ordinal = {4}}},", AFHSBCrossTabFieldName, StartIndex.ToString(), AFHSBOutputLength, CrossTabFieldName, Ordinal);
        }
    }

    public class AFHSBEntryTranslateNeeded : AFHSBEntry
    {
        public List<(string EDCValue, string AFHSBValue)> ApplicationValueWithAFHSBValue { get; set; }

        public string NonMatchAFHSBValue { get; set; } = "";

        public string NullOrEmptyAFHSBValue { get; set; } = "";

        // Constructors
        public AFHSBEntryTranslateNeeded()
        {

        }
        public AFHSBEntryTranslateNeeded(AFHSBEntry entry)
        {
            this.AFHSBCrossTabFieldName = entry.AFHSBCrossTabFieldName;
            this.CrossTabFieldName = entry.CrossTabFieldName;
            this.StartIndex = entry.StartIndex;
            this.AFHSBOutputLength = entry.AFHSBOutputLength;
            this.Ordinal = entry.Ordinal;
            this.CanHaveNullValue = entry.CanHaveNullValue;
            this.ApplicationValueWithAFHSBValue = new List<(string EDCValue, string AFHSBValue)>();
        }

        public AFHSBEntryTranslateNeeded(string AFHSBCTFN, string AppCTFN, int startIndex, int length, int ordinal, List<(string, string)> applicationValueWithAFHSBValue, string nonMatchAFHSBValue = "", string nullOrEmptyAFHSBValue = "", bool nullable = true)
        {
            this.AFHSBCrossTabFieldName = AFHSBCTFN;
            this.CrossTabFieldName = AppCTFN;
            this.StartIndex = startIndex;
            this.AFHSBOutputLength = length;
            this.Ordinal = ordinal;
            this.CanHaveNullValue = nullable;
            this.ApplicationValueWithAFHSBValue = applicationValueWithAFHSBValue;
            this.NonMatchAFHSBValue = nonMatchAFHSBValue;
            this.NullOrEmptyAFHSBValue = nullOrEmptyAFHSBValue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"new AFHSBEntry_TranslateNeeded(){{ AFHSBCrossTabFieldName = ""{0}"", StartIndex = {1}, AFHSBOutputLength = {2}, CrossTabFieldName = ""{3}"", Ordinal = {4},", AFHSBCrossTabFieldName, StartIndex.ToString(), AFHSBOutputLength, CrossTabFieldName, Ordinal);
            sb.AppendLine();
            sb.Append("\t ApplicationValueWithAFHSCValue = new List<(string EDCValue, string AFHSCValue)>(){");
            sb.AppendFormat(@"{0}", string.Join(", ", ApplicationValueWithAFHSBValue.Select(x => "(\"" + x.EDCValue + "\", \"" + x.AFHSBValue + "\")")));
            sb.Append("} },");

            return sb.ToString();
        }
    }
}
