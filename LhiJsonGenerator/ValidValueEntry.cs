using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LhiJsonGenerator
{
    public class ValidValueEntry
    {
        public String CTFN { get; private set; }

        /// <summary>
        /// Valid Value accepted by the system
        /// </summary>
        /// <value>The valid value.</value>
        public String ValidValue { get; private set; }

        /// <summary>
        /// Type of Validation
        /// </summary>
        /// <value>The type of the valid value.</value>
        public ValidValueType ValidValueType { get; private set; }

        public ValidValueEntry(String crossTabFieldName, String validValue, ValidValueType validValueType)
        {
            this.CTFN = crossTabFieldName;
            this.ValidValue = validValue;
            this.ValidValueType = validValueType;
        }
    }
    public enum ValidValueType
    {
        None,

        Text,

        TextArea,
        
        Date,
        
        Radio,
        
        Checkbox,
        
        DropList,
        
        RegEx,
        
        NumericRange
    }
}
