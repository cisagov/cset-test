using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Repositories.NERC_Rev_6;
using Shared = CSET_Selenium.Repositories.Shared;

namespace CSET_Selenium.Repositories.Shared
{
    public class AssessmentRepository : IDisposable
    {
        private Dictionary<string, string> userCredentials = new Dictionary<string, string>();

        public Dictionary<string, string> UserCredentials { get => this.userCredentials; }

        public AssessmentRepository()
        {
            // "william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");
            this.userCredentials.Add("UserName", "william.martin@inl.gov");
            this.userCredentials.Add("PassWord", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");
        }

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

        public Shared.SecurityAssuranceLevel SecurityAssuranceLevel()
        {
            // this line will call a method that will return an initialized object whose
            // properties are set by a file or a databaswe or a web service call
            Shared.SecurityAssuranceLevel level = new Shared.SecurityAssuranceLevel();

            return level;
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
