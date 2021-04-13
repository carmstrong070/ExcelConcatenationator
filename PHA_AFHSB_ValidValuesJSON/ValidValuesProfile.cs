using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHA_AFHSB_ValidValuesJSON
{
    public class ValidValuesProfile
    {
        public string PhaCtfn { get; set; }

        public string AfhsbCtfn { get; set; }

        public string ValueType { get; set; }

        public List<string> PhaValidValues { get; set; } = new List<string>();

        public List<string> AfhsbValidValues { get; set; } = new List<string>();
        
        public ValidValuesProfile() { }

        public ValidValuesProfile(string phaCtfn, string valueType, string phaValue)
        {
            this.PhaCtfn = phaCtfn;
            this.ValueType = valueType;
            this.PhaValidValues.Add(phaValue);
        }
    }

    
}
