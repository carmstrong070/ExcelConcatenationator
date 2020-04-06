using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteToAHLTAGenerator
{
    internal class AHLTAEntry
    {
        public string CTFN { get; set; }

        public string QuestionText { get; set; }

        public string TranslateMethod { get; set; }

        public bool NeedsNewMethod { get; set; } = true;

        internal AHLTAEntry()
        {

        }
        internal AHLTAEntry(string ctfn, string questionText, string translateMethod, bool needsNewMethod)
        {
            this.CTFN = ctfn;
            this.QuestionText = questionText;
            this.TranslateMethod = translateMethod;
            this.NeedsNewMethod = needsNewMethod;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\t\t\t\t\tnew ReviewQuestionGroup");
            sb.AppendLine("\t\t\t\t\t{");
            sb.AppendLine("\t\t\t\t\t\tContentResponses = new List<ReviewContent>");
            sb.AppendLine("\t\t\t\t\t\t{");
            sb.AppendLine("\t\t\t\t\t\t\tnew ReviewContent");
            sb.AppendLine("\t\t\t\t\t\t\t{");
            sb.AppendLine("\t\t\t\t\t\t\t\tIsLabel = true,");
            sb.AppendFormat("\t\t\t\t\t\t\t\ttranslate = kvp => LabelDefinitions.{0}_StaticLabel()\r\n", CTFN);
            sb.AppendLine("\t\t\t\t\t\t\t},");
            sb.AppendLine();
            sb.AppendLine("\t\t\t\t\t\t\tnew ReviewContent");
            sb.AppendLine("\t\t\t\t\t\t\t{");
            sb.AppendFormat("\t\t\t\t\t\t\t\tCrossTabFieldName = \"{0}\",\r\n", CTFN);
            if (NeedsNewMethod)
                sb.AppendFormat("\t\t\t\t\t\t\t\ttranslate = kvp => ValueConversion.translate_NotImplemented(kvp[\"{0}\"])\r\n", CTFN);
            else
                sb.AppendFormat("\t\t\t\t\t\t\t\ttranslate = kvp => ValueConversion.translate_{0}(kvp[\"{1}\"])\r\n", TranslateMethod, CTFN);
            sb.AppendLine("\t\t\t\t\t\t\t}");
            sb.AppendLine("\t\t\t\t\t\t}");
            sb.AppendLine("\t\t\t\t\t},");
            sb.AppendLine();


            return sb.ToString();
        }
    }
}
