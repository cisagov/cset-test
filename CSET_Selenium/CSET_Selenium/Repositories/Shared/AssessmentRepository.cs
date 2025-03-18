using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Repositories.NERC_Rev_6;

namespace CSET_Selenium.Repositories.Shared
{
    public class AssessmentRepository : IDisposable
    {
        public AssessmentInfo AssessmentInfo
        {
            get => new AssessmentInfo()
            {
                AssessmentName = "",
                AssessmentDate = DateTime.Now.AddDays(1),
                FacilityName = "",
                City = "",
                State = ""
            };
        }

        public AssessmentConfiguration AssessmentConfig
        {
            get => new AssessmentConfiguration()
            {
                AssessmentName = "NERC CIP-002 through CIP-014 Revision 6",
                AssessmentDate = DateTime.Now.AddDays(1),
                FacilityName = "S.T.A.R.Labs",
                City = "Star City",
                State = "WA"
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
