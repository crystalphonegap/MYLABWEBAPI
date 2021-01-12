using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PathalogyTestDetails
    {
        public int TESTDET_CurrentId { get; set; }
        public int TESTDET_TestMasterID { get; set; }
        public int TESTDET_FieldNo { get; set; }
        public string TESTDET_FieldName { get; set; }
        public int TESTDET_FieldType { get; set; }
        public string TESTDET_NormalValue { get; set; }
        public string TESTDET_Description { get; set; }
        public string TESTDET_GroupName { get; set; }
        public int TESTDET_GroupNo { get; set; }
        public int TESTDET_FieldStyle { get; set; }
        public bool TESTDET_Compulsory { get; set; }
        public decimal TESTDET_MaxValue { get; set; }
        public decimal TESTDET_MinValue { get; set; }
        public string TESTDET_sDefault { get; set; }
        public string TESTDET_sAlias { get; set; }
        public string TESTDET_sUnit { get; set; }
        public string TESTDET_sFormula { get; set; }
        public decimal TESTDET_MaxLimit { get; set; }
        public decimal TESTDET_MinLimit { get; set; }
        public bool TESTDET_Validate { get; set; }
        public string TESTDET_ANormalValue { get; set; }
        public string TESTDET_BNormalValue { get; set; }
        public string TESTDET_CNormalValue { get; set; }
        public string TESTDET_DNormalValue { get; set; }
        public decimal TESTDET_AMaxValue { get; set; }
        public decimal TESTDET_AMinValue { get; set; }
        public decimal TESTDET_BMaxValue { get; set; }
        public decimal TESTDET_BMinValue { get; set; }
        public decimal TESTDET_CMaxValue { get; set; }
        public decimal TESTDET_CMinValue { get; set; }
        public decimal TESTDET_DMaxValue { get; set; }
        public decimal TESTDET_DMinValue { get; set; }
        public int TESTDET_TestTypeId { get; set; }
        public int TESTDET_CatTypeId { get; set; }
        public string ValueForNormal { get; set; }
    }
}
