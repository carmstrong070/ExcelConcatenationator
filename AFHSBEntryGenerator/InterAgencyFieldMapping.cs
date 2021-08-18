using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFHSBEntryGenerator
{
    public class InterAgencyFieldMapping
    {
        //Properties        
        /// <summary>
        /// The PHA fieldname
        /// </summary>
        public string EpiDataCenter;

        public int EpiDataCenterFieldLength { get; set; }

        /// <summary>
        /// The ahlta fieldname
        /// </summary>
        public string AFHSC;

        public int AfhscFieldLength { get; set; }

        /// <summary>
        /// The Acs-Dal fieldname
        /// </summary>
        public string ACSDAL;

        public int AcsDalFieldLength { get; set; }

        /// <summary>
        /// SegmenArea Associate with the field
        /// </summary>
        public AssessmentSegmentArea SegmentArea;
    }

    [Flags]
    public enum AssessmentSegmentArea
    {
        ServiceMember = 1,
        RecordReviewer = 2,
        MHAProvider = 4,
        HCP = 8,
        Other = 16,
        IndexTableFields = 32
    }
}
