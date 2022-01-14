using System.Collections.Generic;

namespace myLabWebApi.Models
{
    public class PathalogyTestDetails
    {
        public string TESTDET_CurrentId { get; set; }
        public string TESTDET_TestMasterID { get; set; }
        public string TESTDET_FieldNo { get; set; }
        public string TESTDET_FieldName { get; set; }
        public string TESTDET_FieldType { get; set; }
        public string TESTDET_NormalValue { get; set; }
        public string TESTDET_Description { get; set; }
        public string TESTDET_GroupName { get; set; }
        public string TESTDET_GroupNo { get; set; }
        public string TESTDET_FieldStyle { get; set; }
        public bool TESTDET_Compulsory { get; set; }
        public string TESTDET_MaxValue { get; set; }
        public string TESTDET_MinValue { get; set; }
        public string TESTDET_sDefault { get; set; }
        public string TESTDET_sAlias { get; set; }
        public string TESTDET_sUnit { get; set; }
        public string TESTDET_sFormula { get; set; }
        public string TESTDET_MaxLimit { get; set; }
        public string TESTDET_MinLimit { get; set; }
        public bool TESTDET_Validate { get; set; }
        public string TESTDET_ANormalValue { get; set; }
        public string TESTDET_BNormalValue { get; set; }
        public string TESTDET_CNormalValue { get; set; }
        public string TESTDET_DNormalValue { get; set; }
        public string TESTDET_AMaxValue { get; set; }
        public string TESTDET_AMinValue { get; set; }
        public string TESTDET_BMaxValue { get; set; }
        public string TESTDET_BMinValue { get; set; }
        public string TESTDET_CMaxValue { get; set; }
        public string TESTDET_CMinValue { get; set; }
        public string TESTDET_DMaxValue { get; set; }
        public string TESTDET_DMinValue { get; set; }
        public string TESTDET_TestTypeId { get; set; }
        public string TESTDET_CatTypeId { get; set; }
        public string ValueForNormal { get; set; }
        public List<PREDEFVALModel> PREDEFVALModel { get; set; }
    }
}