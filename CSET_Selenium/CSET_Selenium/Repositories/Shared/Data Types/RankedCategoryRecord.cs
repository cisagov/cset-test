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
        /// <param name="failed"></param>
        /// <param name="total"></param>
        /// <param name="percent"></param>
        public RankedCategoryRecord(string name, int rank, int failed, int total, float percent)
        {
            Name = name;
            Rank = rank;
            Failed = failed;
            Total = total;
            Percent = percent;
        }

        public string Name { get; set; }
        public int Rank { get; set; }
        public int Failed { get; set; }
        public int Total { get; set; }
        public float Percent { get; set; }
    }
}
