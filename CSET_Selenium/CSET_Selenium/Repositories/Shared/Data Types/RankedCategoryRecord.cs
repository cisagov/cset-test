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
    internal class RankedCategoryRecord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        /// <param name="value"></param>
        public RankedCategoryRecord(string name, int rank, int value)
        {
            Name = name;
            Rank = rank;
            Value = value;
        }

        public string Name { get; set; }
        public int Rank { get; set; }
        public int Value { get; set; } = 0;
    }
}
