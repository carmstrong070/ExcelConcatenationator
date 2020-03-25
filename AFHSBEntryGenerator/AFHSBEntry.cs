using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFHSBEntryGenerator
{
    class AFHSBEntry
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
        }
        public override string ToString()
        {
            return string.Format("", AFHSBCrossTabFieldName, StartIndex.ToString(), AFHSBOutputLength, CrossTabFieldName, Ordinal);
        }
    }
}
