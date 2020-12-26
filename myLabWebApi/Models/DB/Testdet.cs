using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Testdet
    {
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
        public int? TestdetTestTypeId { get; set; }
        public int? TestdetCatTypeId { get; set; }
    }
}
