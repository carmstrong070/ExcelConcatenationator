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
}
