using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Testmaster
    {
        public int TestmstCurrentId { get; set; }
        public string TestmstName { get; set; }
        public string TestmstPrintFormat { get; set; }
        public double? TestmstRate { get; set; }
        public string TestmstReportHeading { get; set; }
        public string Type { get; set; }
        public double? TestmstTestcost { get; set; }
        public string TestmstAlias { get; set; }
        public double? TestmstPercentage { get; set; }
        public double? TestmstLumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int? TestmstCompanyid { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestmstCatType { get; set; }
        public string SpecialTest { get; set; }
        public string TestmstSample { get; set; }
        public int TestdetCurrentId { get; set; }
        public int? TestdetTestMasterId { get; set; }
        public int? TestdetFieldNo { get; set; }
        public string TestdetFieldName { get; set; }
        public short? TestdetFieldType { get; set; }
        public string TestdetNormalValue { get; set; }
        public string TestdetDescription { get; set; }
        public string TestdetGroupName { get; set; }
        public int? TestdetGroupNo { get; set; }
        public short? TestdetFieldStyle { get; set; }
        public bool? TestdetCompulsory { get; set; }
        public double? TestdetMaxValue { get; set; }
        public double? TestdetMinValue { get; set; }
        public string TestdetSDefault { get; set; }
        public string TestdetSAlias { get; set; }
        public string TestdetSUnit { get; set; }
        public string TestdetSFormula { get; set; }
        public double? TestdetMaxLimit { get; set; }
        public double? TestdetMinLimit { get; set; }
        public bool? TestdetValidate { get; set; }
        public string TestdetAnormalValue { get; set; }
        public string TestdetBnormalValue { get; set; }
        public string TestdetCnormalValue { get; set; }
        public string TestdetDnormalValue { get; set; }
        public double? TestdetAmaxValue { get; set; }
        public double? TestdetAminValue { get; set; }
        public double? TestdetBmaxValue { get; set; }
        public double? TestdetBminValue { get; set; }
        public double? TestdetCmaxValue { get; set; }
        public double? TestdetCminValue { get; set; }
        public double? TestdetDmaxValue { get; set; }
        public double? TestdetDminValue { get; set; }
        public int? PredefvalId { get; set; }
        public int? PredefvalFieldid { get; set; }
        public int? PredefvalValNo { get; set; }
        public string PredefvalValue { get; set; }
    }
}
