using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.Shared.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    internal class StandardSummaryRecord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public StandardSummaryRecord(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }
}
