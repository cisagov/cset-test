using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    public class StandardQuestions
    {
        public AccountManagement AccountManagement
        {
            get => new AccountManagement();
        }

        public ConfigurationManagement ConfigurationManagement
        {
            get => new ConfigurationManagement();
        }
        public Inventory Inventory
        {
            get => new Inventory();
        }
        public IncidentResponse IncidentResponse
        {
            get => new IncidentResponse();
        }
        public PhysicalSecurity PhysicalSecurity
        {
            get => new PhysicalSecurity();
        }
        public PhysicalSecurityPlans PhysicalSecurityPlans
        {
            get => new PhysicalSecurityPlans();
        }
        public Policies Policies
        {
            get => new Policies();
        }
        public Recovery Recovery
        {
            get => new Recovery();
        }
        public RiskAssessment RiskAssessment
        {
            get => new RiskAssessment();
        }
        public SystemProtection SystemProtection
        {
            get => new SystemProtection();
        }
        public VulnerabilityAssementAndManagement VulnerabilityAssementAndManagement
        {
            get => new VulnerabilityAssementAndManagement();
        }
    }
}
