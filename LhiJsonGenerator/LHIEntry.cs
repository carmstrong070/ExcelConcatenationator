using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhiJsonGenerator
{
    public class LHIEntry
    {
        public string className { get; set; }

        public string assessmentType { get; set; }

        public string assessmentVersion { get; set; }

        public List<LHIField> Fields { get; set; }
    }

    public class LHIField
    {
        public string edhaCFName { get; set; }

        public string lhiCFName { get; set; }

        public string edhaValueDataType { get; set; }

        public string lhiValueDataType { get; set; }

        public Dictionary<string, string> valueMapping { get; set; }

        public bool useValueAsIs { get; set; } = false;
    }
}
