using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirmenFSCTableGenerator
{
    public class AirmenFscEntry
    {
        public int SffpNumber { get; set; }
        public string SffpCtfn { get; set; }

        public string SffpTextCtfn { 
            get 
            {
                if (!String.IsNullOrEmpty(SffpCtfn) && SffpCtfn.Contains("MEDICATIONS_LIST"))
                {
                    return SffpCtfn;
                }
                return SffpCtfn + "_TEXT"; 
            } 
            set { } 
        }

        public string FscProvCommentsCtfn { 
            get 
            {
                if (!String.IsNullOrEmpty(SffpCtfn))
                    return "FSC_PROV_COMMENTS_" + SffpCtfn.Substring(5);
                return null;
            } 
            set { } 
        }

        public string FscCdNcdCtfn { 
            get 
            {
                if (!String.IsNullOrEmpty(SffpCtfn))
                    return "FSC_CD_NCD_" + SffpCtfn.Substring(5);
                return null;
            } 
            set { } 
        }

        public string FscWaiverCtfn { 
            get 
            {
                if (!String.IsNullOrEmpty(SffpCtfn))
                    return "FSC_WAIVER_" + SffpCtfn.Substring(5);
                return null;
            } 
            set { } 
        }

        public string FscIcd10Ctfn { 
            get 
            {
                if (!String.IsNullOrEmpty(SffpCtfn))
                    return "FSC_ICD10_" + SffpCtfn.Substring(5);
                return null;
            } 
            set { } 
        }





    }

    public static class AirmenFscEntryExtensions
    {
        internal static string ToStringHtml(this AirmenFscEntry entry)
        {
            return string.Format(@"                             <tr id=""row{6}"" runat=""server"" class=""hiddenQuestion"">                                  
                                    <td>              
                                        <span>SFFP {0}</span>                               
                                    </td>
                                    <td>
                                        <span class=""textCounter width-large"">
                                            <PTCEnhanced:TextboxEnhanced ID=""txt_{1}"" CrossTabFname=""{1}"" TextMode=""Multiline"" MaxLength=""250"" TabIndex=""0"" runat=""server"" isDirty=""false"" disabled=""disabled""></PTCEnhanced:TextboxEnhanced> 
                                        </span>
                                    </td>
                                    <td>
                                        <span class=""textCounter width-large"">
                                            <PTCEnhanced:TextboxEnhanced ID=""txt_{2}"" CrossTabFname=""{2}"" TextMode=""Multiline"" MaxLength=""250"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:TextboxEnhanced> 
                                        </span>
                                    </td>
                                    <td>
                                        <PTCEnhanced:DropDownListEnhanced ID=""drplst_{3}"" CrossTabFname=""{3}"" TextMode=""SingleLine"" MaxLength=""3"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:DropDownListEnhanced>
                                    </td>
                                    <td>
                                        <PTCEnhanced:DropDownListEnhanced ID=""drplst_{4}"" CrossTabFname=""{4}"" TextMode=""SingleLine"" MaxLength=""3"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:DropDownListEnhanced>
                                    </td>
                                    <td>
                                        <PTCEnhanced:TextboxEnhanced ID=""txt_{5}"" CrossTabFname=""{5}"" TextMode=""SingleLine"" MaxLength=""10"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:TextboxEnhanced> 
                                    </td>
                                </tr>", entry.SffpNumber, entry.SffpTextCtfn, entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn, entry.SffpCtfn);
        }

        internal static string ToStringInitialControlState(this AirmenFscEntry entry)
        {
            return string.Format(@"            if (SegmentData.ContainsKey(""{0}"") && SegmentData[""{0}""] == ""Y"")
            {{
                row{0}.Attributes[""class""] = """";
                if (IsHCP)
                {{
                    this.cVal_{1}.Enabled = true;
                    this.cVal_{2}.Enabled = true;
                }}
            }}", entry.SffpCtfn, entry.FscProvCommentsCtfn, entry.FscWaiverCtfn);
        }

        internal static string ToStringResponseReview(this AirmenFscEntry entry)
        {
            return string.Format(@"", entry.SffpCtfn);
        }

        internal static string ToStringAHLTA(this AirmenFscEntry entry)
        {
            return string.Format(@"", entry.SffpCtfn);
        }
    }
}
