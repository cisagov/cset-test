﻿using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class StandardQuestions : BaseDTOData
    {
        /// <summary>
        /// No initialization parameter means use randomly generated value
        /// </summary>
        public StandardQuestions()
        {
        }

        public int AssessmentCompliance { get { return this.OverallScore; } }
        public int OverallScore { get { return (this.YesCount + this.ALTCount) / (this.TotalQuestionsCount - this.UnansweredCount); } }

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

        /// <summary>
        /// This method is responsible for instructing all containing objects
        /// to initialize themselves.
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.AccountManagement = new AccountManagement();
            this.AccountManagement.Initialize(questionAnswers);

            this.ConfigurationManagement = new ConfigurationManagement();
            this.ConfigurationManagement.Initialize(questionAnswers);

            this.IncidentResponse = new IncidentResponse();
            this.IncidentResponse.Initialize(questionAnswers);

            this.PhysicalSecurity = new PhysicalSecurity();
            this.PhysicalSecurity.Initialize(questionAnswers);

            this.Policies = new Policies();
            this.Policies.Initialize(questionAnswers);

            this.Recovery = new Recovery();
            this.Recovery.Initialize(questionAnswers);

            this.RiskAssessment = new RiskAssessment();
            this.RiskAssessment.Initialize(questionAnswers);

            this.SystemProtection = new SystemProtection();
            this.SystemProtection.Initialize(questionAnswers);

            this.VulnerabilityAssementAndManagement = new VulnerabilityAssementAndManagement();
            this.VulnerabilityAssementAndManagement.Initialize(questionAnswers);
        }

        /// <summary>
        /// This method dynamically builds the answerlist collection so that
        /// all data objects can conveniently report their results for Passed,
        /// Failed, Percentage, and Total--among other values
        /// </summary>
        /// <returns></returns>
        protected override List<QuestionAnswers> SetAnswerList()
        {
            // allocate list
            List<QuestionAnswers> answers = base.SetAnswerList();

            // add property values
            answers.AddRange(this.AccountManagement.AnswerList);
            answers.AddRange(this.ConfigurationManagement.AnswerList);
            answers.AddRange(this.IncidentResponse.AnswerList);
            answers.AddRange(this.PhysicalSecurity.AnswerList);
            answers.AddRange(this.Policies.AnswerList);
            answers.AddRange(this.Recovery.AnswerList);
            answers.AddRange(this.RiskAssessment.AnswerList);
            answers.AddRange(this.SystemProtection.AnswerList);
            answers.AddRange(this.VulnerabilityAssementAndManagement.AnswerList);

            // return list to base class caller
            return answers;
        }

        /// <summary>
        /// This method maps a Key defining the page type with the corresponding object
        /// in the Standard Questions containing object class.
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns></returns>
        public BaseDTOData GetCorrepondingDataObject(RankedCategoryKeyNames keyName)
        {
            BaseDTOData childData = null;

            switch (keyName)
            {
                case RankedCategoryKeyNames.SystemProtection:
                    {
                        childData = this.SystemProtection;

                        break;
                    }
                case RankedCategoryKeyNames.AccountManagement:
                    {
                        childData = this.AccountManagement;

                        break;
                    }
                case RankedCategoryKeyNames.Recovery:
                    {
                        childData = this.Recovery;

                        break;
                    }
                case RankedCategoryKeyNames.RiskManagement:
                    {
                        childData = this.RiskAssessment;

                        break;
                    }
                case RankedCategoryKeyNames.ConfigurationManagement:
                    {
                        childData = this.ConfigurationManagement;

                        break;
                    }
                case RankedCategoryKeyNames.PhysicalSecurity:
                    {
                        childData = this.PhysicalSecurity;

                        break;
                    }
                case RankedCategoryKeyNames.IncidentResponse:
                    {
                        childData = this.IncidentResponse;

                        break;
                    }
                case RankedCategoryKeyNames.VulnerabilityAssessmentAndManagement:
                    {
                        childData = this.VulnerabilityAssementAndManagement;

                        break;
                    }
                case RankedCategoryKeyNames.Policies:
                    {
                        childData = this.Policies;

                        break;
                    }
            }

            return childData;
        }
    }
}
