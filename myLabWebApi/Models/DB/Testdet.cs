using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class TESTDET
    {
        public int TESTDET_CurrentId { get; set; }
        public int? TESTDET_TestMasterID { get; set; }
        public int? TESTDET_FieldNo { get; set; }
        public string TESTDET_FieldName { get; set; }
        public short? TESTDET_FieldType { get; set; }
        public string TESTDET_NormalValue { get; set; }
        public string TESTDET_Description { get; set; }
        public string TESTDET_GroupName { get; set; }
        public int? TESTDET_GroupNo { get; set; }
        public short? TESTDET_FieldStyle { get; set; }
        public bool? TESTDET_Compulsory { get; set; }
        public double? TESTDET_MaxValue { get; set; }
        public double? TESTDET_MinValue { get; set; }
        public string TESTDET_sDefault { get; set; }
        public string TESTDET_sAlias { get; set; }
        public string TESTDET_sUnit { get; set; }
        public string TESTDET_sFormula { get; set; }
        public double? TESTDET_MaxLimit { get; set; }
        public double? TESTDET_MinLimit { get; set; }
        public bool? TESTDET_Validate { get; set; }
        public string TESTDET_ANormalValue { get; set; }
        public string TESTDET_BNormalValue { get; set; }
        public string TESTDET_CNormalValue { get; set; }
        public string TESTDET_DNormalValue { get; set; }
        public double? TESTDET_AMaxValue { get; set; }
        public double? TESTDET_AMinValue { get; set; }
        public double? TESTDET_BMaxValue { get; set; }
        public double? TESTDET_BMinValue { get; set; }
        public double? TESTDET_CMaxValue { get; set; }
        public double? TESTDET_CMinValue { get; set; }
        public double? TESTDET_DMaxValue { get; set; }
        public double? TESTDET_DMinValue { get; set; }
        public int? TESTDET_TestTypeId { get; set; }
        public int? TESTDET_CatTypeId { get; set; }
        public string ValueForNormal { get; set; }
    }
}
