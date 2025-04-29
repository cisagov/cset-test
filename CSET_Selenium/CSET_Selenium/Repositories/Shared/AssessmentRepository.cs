using CSET_Selenium.Enums.SAL;
using System;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public class AssessmentRepository : IDisposable
    {
        private static readonly string defaultUserName = "william.martin@inl.gov";
        private static readonly string defaultPassword = "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'";

        private Dictionary<string, string> userCredentials = new Dictionary<string, string>();

        public Dictionary<string, string> UserCredentials { get => this.userCredentials; }

        /// <summary>
        /// 
        /// </summary>
        public AssessmentRepository() : this(defaultUserName, defaultPassword)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        public AssessmentRepository(string userName, string passWord)
        {
            this.userCredentials.Add("UserName", userName);
            this.userCredentials.Add("PassWord", passWord);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            // throw new NotImplementedException();
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Shared.SecurityAssuranceLevel SecurityAssuranceLevel()
        {
            // this line will call a method that will return an initialized object whose
            // properties are set by a file or a databaswe or a web service call
            Shared.SecurityAssuranceLevel level = new Shared.SecurityAssuranceLevel(
                SAL_Overall.High,
                SAL_Methodology.Simple,
                SAL_Confidentiality.High,
                SAL_Integrity.High,
                SAL_Availability.High
                );

            return level;
        }
    }
}
