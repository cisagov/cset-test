/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Module_Builder
{
    public enum ModuleBuilderReqQuestionHeading
    {
        [ModuleBuilderReqQuestionHeaddingAttr("Access Control")] Access_Control,
        [ModuleBuilderReqQuestionHeaddingAttr("Account Management")] Account_Management,
        [ModuleBuilderReqQuestionHeaddingAttr("Application Security")] Application_Security,
        [ModuleBuilderReqQuestionHeaddingAttr("Audit and Accountability")] Audit_and_Accountability,
        [ModuleBuilderReqQuestionHeaddingAttr("Awareness and Training")] Awareness_and_Training,
        [ModuleBuilderReqQuestionHeaddingAttr("Boundary Protection")] Boundary_Protection,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Communication_Protection,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Configuration_Management,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Contingency_Planning,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Continuity,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Data_Security,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Defense_in_Depth,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Detect,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Disaster_Recovery,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Education,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Encryption,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Environmental_Security,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Firewall,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Governance_and_Risk_Management,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Host_Intrusion_Detection,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Identification_and_Authentication,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Identify,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Incident_Response,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Information_and_document_Managment,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Information_Exchange,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Information_Protection,
        [ModuleBuilderReqQuestionHeaddingAttr("")] Intrusion_Detection,
        [ModuleBuilderReqQuestionHeaddingAttr("")]

    }

    class ModuleBuilderReqQuestionHeaddingAttr : Attribute
    {
        internal ModuleBuilderReqQuestionHeaddingAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class TSAStandardQuestionsExtensions
    {
        public static String GetValue(this TSAStandardQuestions enumChoice)
        {
            var attr = enumChoice.GetAttribute<TSAStandardQuestionsAttr>();
            return attr.Value;
        }
    }
}
*/