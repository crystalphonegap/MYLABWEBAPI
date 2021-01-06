using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class TESTMASTER
    {
        public int TESTMST_CurrentId { get; set; }
        public string TESTMST_Name { get; set; }
        public string TESTMST_PrintFormat { get; set; }
        public double? TESTMST_Rate { get; set; }
        public string TESTMST_ReportHeading { get; set; }
        public string Type { get; set; }
        public double? TESTMST_Testcost { get; set; }
        public string TESTMST_Alias { get; set; }
        public double? TESTMST_Percentage { get; set; }
        public double? TESTMST_Lumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int? TESTMST_Companyid { get; set; }
        public int? TESTMST_TestTypeId { get; set; }
        public string TESTMST_CatType { get; set; }
        public string SpecialTest { get; set; }
        public string TESTMST_sample { get; set; }
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
        public int? PREDEFVAL_Id { get; set; }
        public int? PREDEFVAL_Fieldid { get; set; }
        public int? PREDEFVAL_ValNo { get; set; }
        public string PREDEFVAL_Value { get; set; }
    }
}
