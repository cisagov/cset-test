using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    public class StandardQuestions : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public StandardQuestions(QuestionAnswers questionAnswers)
        {
            this.AccountManagement = new AccountManagement(questionAnswers);
            this.ConfigurationManagement = new ConfigurationManagement(questionAnswers);
            this.IncidentResponse = new IncidentResponse(questionAnswers);
            this.PhysicalSecurity = new PhysicalSecurity(questionAnswers);
            this.Policies = new Policies(questionAnswers);
            this.Recovery = new Recovery(questionAnswers);
            this.RiskAssessment = new RiskAssessment(questionAnswers);
            this.SystemProtection = new SystemProtection(questionAnswers);
            this.VulnerabilityAssementAndManagement = new VulnerabilityAssementAndManagement(questionAnswers);
        }


        /// <summary>
        /// No initialization parameter means use randomly generated value
        /// </summary>
        public StandardQuestions()
        {
            this.AccountManagement = new AccountManagement();
            this.ConfigurationManagement = new ConfigurationManagement();
            this.IncidentResponse = new IncidentResponse();
            this.PhysicalSecurity = new PhysicalSecurity();
            this.Policies = new Policies();
            this.Recovery = new Recovery();
            this.SystemProtection = new SystemProtection();
            this.VulnerabilityAssementAndManagement = new VulnerabilityAssementAndManagement();
        }

        public override bool IsValid()
        {
            return base.IsValid();
        }

        public AccountManagement AccountManagement
        {
            get; private set;
        }

        public ConfigurationManagement ConfigurationManagement
        {
            get; private set;
        }
        public IncidentResponse IncidentResponse
        {
            get; private set;
        }
        public PhysicalSecurity PhysicalSecurity
        {
            get; private set;
        }
        public Policies Policies
        {
            get; private set;
        }
        public Recovery Recovery
        {
            get; private set;
        }
        public RiskAssessment RiskAssessment
        {
            get; private set;
        }
        public SystemProtection SystemProtection
        {
            get; private set;
        }
        public VulnerabilityAssementAndManagement VulnerabilityAssementAndManagement
        {
            get; private set;
        }
    }
}
