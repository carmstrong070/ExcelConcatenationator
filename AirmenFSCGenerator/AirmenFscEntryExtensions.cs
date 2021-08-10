using AirmenFSCTableGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirmenFSCGenerator
{
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
            return string.Format(@"
                            //ROW {0}
							// SFFP Number
							new ReviewContentHTML
							{{
								CrossTabFieldName = ""{1}"",
								IsRedirectable = true,
								translate = kvp => LabelDefinitions.FSC_SFFP_FPE_StaticLabel()
							}},
							new ReviewContentResponse
							{{
								CrossTabFieldName = ""{1}"",
								IsRedirectable = true,
                                translate = kvp => LabelDefinitions.SFFP_{0}StaticLabel()
                            }},

							// SFFP SM Response
							new ReviewContentHTML
							{{
								CrossTabFieldName = ""{2}"",
								IsRedirectable = true,
								translate = kvp => LabelDefinitions.FSC_COMMENTS_StaticLabel()
                            }},
							new ReviewContentResponse
							{{
								CrossTabFieldName = ""{2}"",
								IsRedirectable = true,
								translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{2}""])
                            }},

							// Provider Comments
							new ReviewContentHTML
                            {{
								CrossTabFieldName = ""{3}"",
								IsRedirectable = true,
                                translate = kvp => LabelDefinitions.FSC_PROVIDER_COMMENTS_StaticLabel()
                            }},
							new ReviewContentResponse
                            {{
                                CrossTabFieldName = ""{3}"",
								IsRedirectable = true,
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{3}""])
                            }},

							// NCD/CD
							new ReviewContentHTML
                            {{
                                CrossTabFieldName = ""{4}"",
								IsRedirectable = true,
                                translate = kvp => LabelDefinitions.FSC_CD_NCD_StaticLabel()
                            }},
							new ReviewContentResponse
                            {{
                                CrossTabFieldName = ""{4}"",
								IsRedirectable = true,
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{4}""])
                            }},

							// Waiver
							new ReviewContentHTML
                            {{
                                CrossTabFieldName = ""{5}"",
								IsRedirectable = true,
                                translate = kvp => LabelDefinitions.FSC_WAIVER_StaticLabel()
                            }},
							new ReviewContentResponse
                            {{
                                CrossTabFieldName = ""{5}"",
								IsRedirectable = true,
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{5}""])
                            }},

							// ICD10
							new ReviewContentHTML
                            {{
                                CrossTabFieldName = ""{6}"",
								IsRedirectable = true,
                                translate = kvp => LabelDefinitions.FSC_ICD10_StaticLabel()
                            }},
							new ReviewContentResponse
                            {{
                                CrossTabFieldName = ""{6}"",
								IsRedirectable = true,
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{6}""])
                            }},", entry.SffpNumber, entry.SffpCtfn, entry.SffpTextCtfn, entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn);
        }

        internal static string ToStringAHLTA(this AirmenFscEntry entry)
        {
            return string.Format(@"
                            //ROW {0}
							// SFFP Number
							new ReviewContent
							{{
								IsLabel = true,
								translate = kvp => LabelDefinitions.FSC_SFFP_FPE_StaticLabel()
							}},
							new ReviewContent
							{{
								CrossTabFieldName = ""{1}"",
                                translate = kvp => LabelDefinitions.SFFP_{0}StaticLabel()
                            }},

							// SFFP SM Response
							new ReviewContent
							{{
								IsLabel = true,
								translate = kvp => LabelDefinitions.FSC_COMMENTS_StaticLabel()
                            }},
							new ReviewContent
							{{
								CrossTabFieldName = ""{2}"",
								translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{2}""])
                            }},

							// Provider Comments
							new ReviewContent
                            {{
                                IsLabel = true,
                                translate = kvp => LabelDefinitions.FSC_PROVIDER_COMMENTS_StaticLabel()
                            }},
							new ReviewContent
                            {{
                                CrossTabFieldName = ""{3}"",
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{3}""])
                            }},

							// NCD/CD
							new ReviewContent
                            {{
                                IsLabel = true,
                                translate = kvp => LabelDefinitions.FSC_CD_NCD_StaticLabel()
                            }},
							new ReviewContent
                            {{
                                CrossTabFieldName = ""{4}"",
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{4}""])
                            }},

							// Waiver
							new ReviewContent
                            {{
                                IsLabel = true,
                                translate = kvp => LabelDefinitions.FSC_WAIVER_StaticLabel()
                            }},
							new ReviewContent
                            {{
                                CrossTabFieldName = ""{5}"",
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{5}""])
                            }},

							// ICD10
							new ReviewContent
                            {{
                                IsLabel = true,
                                translate = kvp => LabelDefinitions.FSC_ICD10_StaticLabel()
                            }},
							new ReviewContent
                            {{
                                CrossTabFieldName = ""{6}"",
                                translate = kvp => AHLTA_ValueConversion.TranslateTextboxValue(kvp[""{6}""])
                            }},", entry.SffpNumber, entry.SffpCtfn, entry.SffpTextCtfn, entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn);
        }

        internal static string ToStringValidValues(this AirmenFscEntry entry)
        {
            return string.Format(@"            new CFNameValidValue(""{0}"","""", CFNameValidValueType.Text, 250),
                new CFNameValidValue(""{1}"", """", CFNameValidValueType.Text, 3),
                new CFNameValidValue(""{2}"", """", CFNameValidValueType.Text, 3),
                new CFNameValidValue(""{3}"", """", CFNameValidValueType.Text, 10),

            ", entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn);
        }
    }
}
