using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection
{
    class CybersecurityStandardsSelection : BasePage
    {
        private readonly IWebDriver driver;
        private Actions actions;
        private List<String> standardRecs;

        public CybersecurityStandardsSelection(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            this.actions = new Actions(driver);
        }

        //Element Locators

        private IWebElement RequirementsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Requirements Mode')]"));
            }
        }

        private IWebElement QuestionsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Questions Mode')]"));
            }
        }

        private IWebElement CheckboxNerc_CIP_Rev6
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'NERC_CIP_R6')]"));
            }
        }

        private IWebElement CheckboxCfats
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Cfats']"));
            }
        }

        private IWebElement CheckboxIngaa
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='INGAA']"));
            }
        }

        private IWebElement IngaaOkButton
        {
            get
            {
                return this.driver.FindElement(By.XPath("//app-okay/div/mat-dialog-actions/button"));
            }
        }

        private IWebElement CheckboxCisV6
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='CSC_V6']"));
            }
        }

        private IWebElement CheckboxCisV8
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='CSC_V8']"));
            }
        }

        private IWebElement CheckboxDarkWingDuck
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DW']"));
            }
        }

        private IWebElement CheckboxCybersecMatModelCert102
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='CMMC']"));
            }
        }

        private IWebElement CheckboxDODI8510
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DODI_8510']"));
            }
        }

        private IWebElement CheckboxCnssi1253BaselineV2Mar2014
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Cnssi_1253_V2']"));
            }
        }

        private IWebElement CheckboxNercCipV3
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Nerc_Cip_R3']"));
            }
        }

        private IWebElement CheckboxNercCipV4
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Nerc_Cip_R4']"));
            }
        }

        private IWebElement CheckboxNercCipV5
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Nerc_Cip_R5']"));
            }
        }

        private IWebElement CheckboxNercCipV6
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='NERC_CIP_R6']"));
            }
        }

        private IWebElement CheckboxNistirV1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='NISTIR_7628']"));
            }
        }

        private IWebElement CheckboxNistirV1R1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='NISTIR_7628_R1']"));
            }
        }

        private IWebElement CheckboxPci
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='PCIDSS']"));
            }
        }

        private IWebElement CheckboxCjis
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='CJIS_V5.8']"));
            }
        }

        private IWebElement CheckboxC2M2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C2M2_V11']"));
            }
        }
        private IWebElement CheckboxCatalogRecsR7
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Cor_7']"));
            }
        }
        private IWebElement CheckboxNistR2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_171']"));
            }
        }
        private IWebElement CheckboxControlCorrelationIdV2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='CCI_V2']"));
            }
        }
        private IWebElement CheckboxAwwa
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='AWWA']"));
            }
        }

        private IWebElement ContinueAfterAwwa
        {
            get 
            {
                return this.driver.FindElement(By.XPath("//app-awwa-standard/div/mat-dialog-content/div/table/tr[3]/td[1]/button"));
            }
        }
        private IWebElement CheckboxHipaasr
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='HIPAA']"));
            }
        }
        private IWebElement CheckboxNistSpR5
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_53_R5_V2']"));
            }
        }
        private IWebElement CheckboxNistSpR4
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_53_R4_71']"));
            }
        }
        private IWebElement CheckboxNistSpR4AppendixJ
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_53_R4_App_J']"));
            }
        }
        private IWebElement CheckboxNistSpR3
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_53_R3']"));
            }
        }
        private IWebElement CheckboxContinuousReqEveryYear
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DonvEY']"));
            }
        }
        private IWebElement CheckboxContinuousY1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DonvY1']"));
            }
        }
        private IWebElement CheckboxContinuousY2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DonvY2']"));
            }
        }
        private IWebElement CheckboxContinuousY3
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='DonvY3']"));
            }
        }
        private IWebElement CheckboxFrameworkImprovingCriticalInfraCyber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='NCSF_V1']"));
            }
        }
        private IWebElement CheckboxNeiCyberPlanNuclearPowerReactors
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='NEI_0809']"));
            }
        }
        private IWebElement CheckboxNrcRegGuide571
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Nrc_571']"));
            }
        }
        private IWebElement CheckboxHLCIA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='HLCIA']"));
            }
        }
        private IWebElement CheckboxANSSec
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='ISA-62443']"));
            }
        }
        private IWebElement CheckboxNistSpR3AppendixI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_53_R3_App_I']"));
            }
        }
        private IWebElement CheckboxNistSp80082
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_82']"));
            }
        }
        private IWebElement CheckboxNistSp80082R1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_82_V1']"));
            }
        }
        private IWebElement CheckboxNistSp80082R2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='SP800-82 V2']"));
            }
        }
        private IWebElement CheckboxVadr
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='SET.20220302.130836']"));
            }
        }
        private IWebElement CheckboxKeyQuestions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Key']"));
            }
        }
        private IWebElement CheckboxUniversalQuestions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Universal']"));
            }
        }
        private IWebElement CheckboxNistSpSupplyChainRiskManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='C800_161']"));
            }
        }
        private IWebElement CheckboxFaa
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='FAA_PED_V2']"));
            }
        }
        private IWebElement CheckboxDefiningSecZoneArchRailTransitProtectCritZones
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='APTA_Rail_V1']"));
            }
        }
        private IWebElement CheckboxFaaPortableElectronicDevices
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='FAA_MAINT']"));
            }
        }
        private IWebElement CheckboxTsaPipelineSecGuidelinesApril2011
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='Tsa']"));
            }
        }
        private IWebElement CheckboxTsaPipelineSecGuidelinesMarch208wApril2021Revision
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='TSA2018']"));
            }
        }

/*   THIS IS THE START OF THE STANDARD QUESTIONS PAGE 
private IWebElement ButtonBasicAssessment
{
    get
    {
        return WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-prepare/app-standards/div/div/div[1]/div/button"));
    }
}


private IWebElement CSSBasicExpandAll
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[2]/div[2]/div[1]/button[2]"));
    }

}
private IWebElement CSSBasicCollapseAll
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[2]/div[2]/div[1]/button[1]"));
    }

}

private IWebElement CSSBasicQuestionsFilter
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[2]/div[2]/div[1]/button[3]"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckSelectDeselectAll
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbSelectAll']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckYes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowOptionY']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckNO
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowOptionN']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckNA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowOptionNA']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckAlternate
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowOptionA']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckUnanswered
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowU']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckWithComments
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowComments']"));
    }

}
private IWebElement CSSBasicQuestionsFilterCheckFeedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowFeedback']"));
    }

}

private IWebElement CSSBasicQuestionsFilterCheckReview
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowReview']"));
    }

}

private IWebElement CSSBasicQuestionsFilterCheckObs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='cbShowDisc']"));
    }
}

private IWebElement CSSBasicQuestionsFilterOK
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='mat-dialog-6']/app-question-filters/div/mat-dialog-actions/button"));
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[1]/div[1]/div[1]/span");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreementsYes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreementsNo
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreementsNA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements1Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id="sidenav-content"]/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/div/div[2]/div[1]/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessAgreements2Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[2]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[1]/div[1]/div[1]/span");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/div/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardAccessEnforcement3Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[3]/app-question-block/div/div[2]/div/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[1]/div[1]/div[1]/span");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementationYes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementationNo
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementationNA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation4Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id="sidenav - content"]/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/div/div[2]/div[1]/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardAuthenticationImplementation5Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[4]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[1]/div[1]/span");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswordsYes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswordsNo
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswordsNA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id="sidenav - content"]/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/div/div[2]/div[1]/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardPasswords7Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[2]/app-question-extras/div/div[1]/span/label");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[6]/app-question-block/div/div[1]/div[1]/div[1]/span");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotificationYes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotificationNo
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotificationNA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Yes
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8No
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8NA
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Alt
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Flag
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/div/div[2]/div/label[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Details
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[1]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Guidance
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[2]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Comment
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[3]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Docs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[4]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Refs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[5]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Obs
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[6]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Feedback
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/button[7]");
    }
}

private IWebElement CSSBasicQuestionsStandardSystemUseNotification8Reviewed
{
    get
    {
        return WaitUntilElementIsVisible(By.Xpath("//*[@id='sidenav-content']/app-questions/div/div[3]/app-category-block/div[5]/app-question-block/div/div[2]/div[1]/app-question-extras/div/div[1]/span/label");
    }
}
*/

//Interaction Methods


        private void ClickRecommendedStandards()
        {
            //Click the recommended standards
            var recommendedList = driver.FindElements(By.XPath("//span[contains(text(), 'recommended')]/ancestor::label"));
            if(recommendedList.Count() > 0)
            {
                foreach (IWebElement el in recommendedList)
                {
                    WaitUntilElementIsVisible(el);
                    el.Click();
              //      standardRecs.Add(el.GetAttribute("value"));
                }
            }
            //If there aren't recommendations, click "I want to do a basic assessment instead"
            else
            {
                WaitUntilElementIsVisible(By.XPath("//button[@mattooltip='Start an assessment with a basic standard selected']")).Click();
              //  standardRecs.Add()
            }

        }

        private void ClickNerc_CIP_Rev6()
        {
            CheckboxNerc_CIP_Rev6.Click();
        }

        private void ClickCfats()
        {
            CheckboxCfats.Click();
        }
        private void ClickIngaa()
        {
            CheckboxIngaa.Click();
        }
        private void ClickCisV6()
        {
            CheckboxCisV6.Click();
        }
        private void ClickCisV8()
        {
            CheckboxCisV8.Click();
        }
        private void ClickDarkWingDuck()
        {
            CheckboxDarkWingDuck.Click();
        }
        private void ClickCybersecMatModelCert102()
        {
            CheckboxCybersecMatModelCert102.Click();
        }
        private void ClickCheckboxDODI8510()
        {
            CheckboxDODI8510.Click();
        }

        private void ClickCheckboxCnssi1253BaselineV2Mar2014()
        {
            CheckboxCnssi1253BaselineV2Mar2014.Click();
        }

        private void ClickCheckboxNercCipV3()
        {
            CheckboxNercCipV3.Click();
        }

        private void ClickCheckboxNercCipV4()
        {
            CheckboxNercCipV4.Click();
        }

        private void ClickCheckboxNercCipV5()
        {
            CheckboxNercCipV5.Click();
        }

        private void ClickCheckboxNercCipV6()
        {
            CheckboxNercCipV6.Click();
        }

        private void ClickCheckboxNistirV1()
        {
           CheckboxNistirV1.Click();
        }

        private void ClickCheckboxNistirV1R1()
        {
            CheckboxNistirV1R1.Click();
        }

        private void ClickCheckboxPci()
        {
            CheckboxPci.Click();
        }

        private void ClickCheckboxCjis()
        {
           CheckboxCjis.Click();
        }

        private void ClickCheckboxC2M2()
        {
            CheckboxC2M2.Click();
        }
        private void ClickCheckboxCatalogRecsR7()
        {
            CheckboxCatalogRecsR7.Click();
        }
        private void ClickCheckboxNistR2()
        {
            CheckboxNistR2.Click();
        }
        private void ClickCheckboxControlCorrelationIdV2()
        {
            CheckboxControlCorrelationIdV2.Click();
        }
        private void ClickCheckboxAwwa()
        {
            CheckboxAwwa.Click();
        }
        private void ClickCheckboxHipaasr()
        {
            retryButtonScroll(CheckboxHipaasr, actions);
            retryButtonClick(CheckboxHipaasr);
        }
        private void ClickCheckboxNistSpR5()
        {
            CheckboxNistSpR5.Click();
        }
        private void ClickCheckboxNistSpR4()
        {
            CheckboxNistSpR4.Click();
        }
        private void ClickCheckboxNistSpR4AppendixJ()
        {
            CheckboxNistSpR4AppendixJ.Click();
        }
        private void ClickCheckboxNistSpR3()
        {
            CheckboxNistSpR3.Click();
        }
        private void ClickCheckboxContinuousReqEveryYear()
        {
            CheckboxContinuousReqEveryYear.Click();
        }
        private void ClickCheckboxContinuousY1()
        {
            CheckboxContinuousY1.Click();
        }
        private void ClickCheckboxContinuousY2()
        {
            CheckboxContinuousY2.Click();
        }
        private void ClickCheckboxContinuousY3()
        {
            CheckboxContinuousY3.Click();
        }
        private void ClickCheckboxFrameworkImprovingCriticalInfraCyber()
        {
            CheckboxFrameworkImprovingCriticalInfraCyber.Click();
        }
        private void ClickCheckboxNeiCyberPlanNuclearPowerReactors()
        {
            CheckboxNeiCyberPlanNuclearPowerReactors.Click();
        }
        private void ClickCheckboxNrcRegGuide571()
        {
            CheckboxNrcRegGuide571.Click();
        }
        private void ClickCheckboxHLCIA()
        {
            CheckboxHLCIA.Click();
        }
        private void ClickCheckboxANSSec()
        {
            CheckboxANSSec.Click();          
         }
        private void ClickCheckboxNistSpR3AppendixI()
        {
            CheckboxNistSpR3AppendixI.Click();
        }
        private void ClickCheckboxNistSp80082()
        {
            CheckboxNistSp80082.Click();
        }
        private void ClickCheckboxNistSp80082R1()
        {
            CheckboxNistSp80082R1.Click();
        }
        private void ClickCheckboxNistSp80082R2()
        {
            CheckboxNistSp80082R2.Click();
        }
        private void ClickCheckboxVadr()
        {
            CheckboxVadr.Click();
        }
        private void ClickCheckboxKeyQuestions()
        {
            CheckboxKeyQuestions.Click();
        }
        private void ClickCheckboxUniversalQuestions()
        {
           CheckboxUniversalQuestions.Click();
        }
        private void ClickCheckboxNistSpSupplyChainRiskManagement()
        {
            CheckboxNistSpSupplyChainRiskManagement.Click();
        }
        private void ClickCheckboxFaa()
        {
            CheckboxFaa.Click();
        }
        private void ClickCheckboxDefiningSecZoneArchRailTransitProtectCritZones()
        {
            CheckboxDefiningSecZoneArchRailTransitProtectCritZones.Click();
        }
        private void ClickCheckboxFaaPortableElectronicDevices()
        {
            CheckboxFaaPortableElectronicDevices.Click();
        }
        private void ClickCheckboxTsaPipelineSecGuidelinesApril2011()
        {
            CheckboxTsaPipelineSecGuidelinesApril2011.Click();
        }
        private void ClickCheckboxTsaPipelineSecGuidelinesMarch208wApril2021Revision()
        {
            CheckboxTsaPipelineSecGuidelinesMarch208wApril2021Revision.Click();
        }

        private void ClickRequirementsMode()
        {
            RequirementsMode.Click();
        }

        private void ClickQuestionsMode()
        {
            QuestionsMode.Click();
        }


//Aggregate Methods
        
        public void RecommendedStandards()
        {
            ClickRecommendedStandards();
            driver.FindElement(By.XPath("//button[contains(text(), 'Next')]"));
        }

        public void SetRequirementsMode()
        {
            ClickRequirementsMode();
        }

        public void SetQuestionsMode()
        {
            ClickQuestionsMode();
        }

        public void SetNerc_CIP_Rev6()
        {
            ClickNerc_CIP_Rev6();
        }

        public void SetCfats()
        {
            ClickCfats();
        }
        public void SetIngaa()
        {
            ClickIngaa();
        }

        public void SelectOkAfterIngaa()
        {
            actions.MoveToElement(IngaaOkButton);
            retryButtonClick(IngaaOkButton);
        }

        public void SetCISV6()
        {
            ClickCisV6();
        }
        public void SetCISV8()
        {
            ClickCisV8();
        }
        public void SetDWD()
        {
            ClickDarkWingDuck();
        }
        public void SetCybersecMatModelCert102()
        {
            ClickCybersecMatModelCert102();
        }
        public void SetCheckboxDODI8510()
        {
            ClickCheckboxDODI8510();
        }

        public void SetCheckboxCnssi1253BaselineV2Mar2014()
        {
            ClickCheckboxCnssi1253BaselineV2Mar2014();
        }

        public void SetCheckboxNercCipV3()
        {
            ClickCheckboxNercCipV3();
        }

        public void SetCheckboxNercCipV4()
        {
            ClickCheckboxNercCipV4();
        }

        public void SetCheckboxNercCipV5()
        {
            ClickCheckboxNercCipV5();
        }

        public void SetCheckboxNercCipV6()
        {
            ClickCheckboxNercCipV6();
        }

        public void SetCheckboxNistirV1()
        {
            ClickCheckboxNistirV1();
        }

        public void SetCheckboxNistirV1R1()
        {
            ClickCheckboxNistirV1R1();
        }

        public void SetCheckboxPci()
        {
            ClickCheckboxPci();
        }

        public void SetCheckboxCjis()
        {
            ClickCheckboxCjis();
        }

        public void SetCheckboxC2M2()
        {
            ClickCheckboxC2M2();
        }
        public void SetCheckboxCatalogRecsR7()
        {
            ClickCheckboxCatalogRecsR7();
        }
        public void SetCheckboxNistR2()
        {
            ClickCheckboxNistR2();
        }
        public void SetCheckboxControlCorrelationIdV2()
        {
            ClickCheckboxControlCorrelationIdV2();
        }
        public void SetCheckboxAwwa()
        {
            ClickCheckboxAwwa();
        }

        public void SelectContinueAfterAwwa()
        {
            retryButtonClick(ContinueAfterAwwa);
        }

        public void SetCheckboxHipaasr()
        {
            ClickCheckboxHipaasr();
        }
        public void SetCheckboxNistSpR5()
        {
            ClickCheckboxNistSpR5();
        }
        public void SetCheckboxNistSpR4()
        {
            ClickCheckboxNistSpR4();
        }
        public void SetCheckboxNistSpR4AppendixJ()
        {
            ClickCheckboxNistSpR4AppendixJ();
        }
        public void SetCheckboxNistSpR3()
        {
            ClickCheckboxNistSpR3();
        }
        public void SetCheckboxContinuousReqEveryYear()
        {
            ClickCheckboxContinuousReqEveryYear();
        }
        public void SetCheckboxContinuousY1()
        {
            ClickCheckboxContinuousY1();
        }
        public void SetCheckboxContinuousY2()
        {
            ClickCheckboxContinuousY2();
        }
        public void SetCheckboxContinuousY3()
        {
            ClickCheckboxContinuousY3();
        }
        public void SetCheckboxFrameworkImprovingCriticalInfraCyber()
        {
            ClickCheckboxFrameworkImprovingCriticalInfraCyber();
        }
        public void SetCheckboxNeiCyberPlanNuclearPowerReactors()
        {
            ClickCheckboxNeiCyberPlanNuclearPowerReactors();
        }
        public void SetCheckboxNrcRegGuide571()
        {
            ClickCheckboxNrcRegGuide571();
        }
        public void SetCheckboxHLCIA()
        {
            ClickCheckboxHLCIA();
        }
        public void SetCheckboxHighANSSec()
        {
            ClickCheckboxANSSec();
        }
        public void SetCheckboxNistSpR3AppendixI()
        {
            ClickCheckboxNistSpR3AppendixI();
        }
        public void SetCheckboxNistSp80082()
        {
            ClickCheckboxNistSp80082();
        }
        public void SetCheckboxNistSp80082R1()
        {
            ClickCheckboxNistSp80082R1();
        }
        public void SetCheckboxNistSp80082R2()
        {
            ClickCheckboxNistSp80082R2();
        }
        public void SetCheckboxVadr()
        {
            ClickCheckboxVadr();
        }
        public void SetCheckboxKeyQuestions()
        {
            ClickCheckboxKeyQuestions();
        }
        public void SetCheckboxUniversalQuestions()
        {
            ClickCheckboxUniversalQuestions();
        }
        public void SetCheckboxNistSpSupplyChainRiskManagement()
        {
            ClickCheckboxNistSpSupplyChainRiskManagement();
        }
        public void SetCheckboxFaa()
        {
            ClickCheckboxFaa();
        }
        public void SetCheckboxDefiningSecZoneArchRailTransitProtectCritZones()
        {
            ClickCheckboxDefiningSecZoneArchRailTransitProtectCritZones();
        }
        public void SetCheckboxFaaPortableElectronicDevices()
        {
            ClickCheckboxFaaPortableElectronicDevices();
        }
        public void SetCheckboxTsaPipelineSecGuidelinesApril2011()
        {
            ClickCheckboxTsaPipelineSecGuidelinesApril2011();
        }
        public void SetCheckboxTsaPipelineSecGuidelinesMarch208wApril2021Revision()
        {
            ClickCheckboxTsaPipelineSecGuidelinesMarch208wApril2021Revision();
            ClickNext();
        }
    }
}
