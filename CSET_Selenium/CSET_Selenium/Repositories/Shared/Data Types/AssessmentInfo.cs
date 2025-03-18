using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6
{
    public class AssessmentInfo
    {
        public string AssessmentName { get; set; }
        public string FacilityName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime AssessmentDate { get; set; }
    }
}
