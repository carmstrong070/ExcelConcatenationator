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
            return string.Format(@"                                <tr id=""row{6}"" runat=""server"" class=""hiddenQuestion"">                                  
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
                                            <asp:CustomValidator ID=""cVal_{2}"" Enabled=""false"" Text=""*required"" ValidationGroup=""{2}"" ClientValidationFunction=""Validate_{2}"" EnableClientScript=""true"" runat=""server"" Display=""Dynamic"" CssClass=""error"" ></asp:CustomValidator>
                                            <br />
                                            <PTCEnhanced:TextboxEnhanced ID=""txt_{2}"" CrossTabFname=""{2}"" TextMode=""Multiline"" MaxLength=""250"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:TextboxEnhanced> 
                                        </span>
                                    </td>
                                    <td>
                                        <PTCEnhanced:DropDownListEnhanced ID=""drplst_{3}"" Enabled=""false"" CrossTabFname=""{3}"" TextMode=""SingleLine"" MaxLength=""3"" TabIndex=""0"" runat=""server"" isDirty=""false""></PTCEnhanced:DropDownListEnhanced>
                                    </td>
                                    <td>
                                        <asp:CustomValidator ID=""cVal_{4}"" Enabled=""false"" Text=""*required"" ValidationGroup=""{4}"" ClientValidationFunction=""Validate_{4}"" EnableClientScript=""true"" runat=""server"" Display=""Dynamic"" CssClass=""error"" ></asp:CustomValidator>
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
            return string.Format(@"                new CFNameValidValue(""{0}"","""", CFNameValidValueType.Text, 250),
                new CFNameValidValue(""{1}"", ""CD"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{1}"", ""NCD"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{2}"", ""WR"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{2}"", ""WP"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{2}"", ""WG"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{2}"", ""WNR"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{2}"", ""Other"", CFNameValidValueType.DropList),
                new CFNameValidValue(""{3}"", """", CFNameValidValueType.Text, 10),
            ", entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn);
        }

        internal static string ToStringValidation(this AirmenFscEntry entry)
        {
            return String.Format(@"        function Validate_{0}(sender, args) {{

            if ( <%= IsHCP ? ""true"" : ""false""%> && document.getElementById(""txt_{0}"").value.length < 1) {{
                    args.IsValid = false;
            }}
            else {{
                args.IsValid = true;
            }}
        }}

        function Validate_{1}(sender, args) {{

            if ( <%= IsHCP ? ""true"" : ""false""%> && document.getElementById(""drplst_{2}"").value == ""CD"" && document.getElementById(""drplst_{1}"").value.length < 1) {{
                args.IsValid = false;
            }}
            else {{
                args.IsValid = true;
            }}
        }}", entry.FscProvCommentsCtfn, entry.FscWaiverCtfn, entry.FscCdNcdCtfn);
        }

        internal static string ToStringAskedEngineMethod(this AirmenFscEntry entry)
        {
            return string.Format(@"        internal static Tuple<string[], string[]> {0}_SetAskedStateForChildren(Dictionary<string, string> savedValues)
        {{
            //Get the saved value if it exists, otherwise value is blank
            var savedValue = savedValues.ContainsKey(""{0}"") ? savedValues[""{0}""] : """";

            //Asked/Not Asked Lists
            List<string> askedCtfns = new List<string>();
            List<string> notAskedCtfns = new List<string>();

            //Determine if the ""{0}"" is answered as ""Y"" and sets Asked State
            if (savedValue == ""Y"")
            {{
                askedCtfns.Add(""{1}"");
                askedCtfns.Add(""{2}"");
                askedCtfns.Add(""{3}"");
                askedCtfns.Add(""{4}"");
                askedCtfns.Add(""{5}"");
            }}
            else
            {{
                notAskedCtfns.Add(""{1}"");
                notAskedCtfns.Add(""{2}"");
                notAskedCtfns.Add(""{3}"");
                notAskedCtfns.Add(""{4}"");
                notAskedCtfns.Add(""{5}"");
            }}

            //Return the Asked lists as string arrays
            return new Tuple<string[], string[]>(askedCtfns.ToArray(), notAskedCtfns.ToArray());
        }}
            ", entry.SffpCtfn, entry.SffpTextCtfn, entry.FscProvCommentsCtfn, entry.FscCdNcdCtfn, entry.FscWaiverCtfn, entry.FscIcd10Ctfn);
        }

        internal static string ToStringAskedEngineRegistry(this AirmenFscEntry entry)
        {
            return string.Format(@"            {{ ""{0}"", AskedCalculators.{0}_SetAskedStateForChildren }},", entry.SffpCtfn);
        }
    }
}
