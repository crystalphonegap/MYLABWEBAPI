using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Param
    {
        public short ParamCode { get; set; }
        public string ParamName { get; set; }
        public string ParamPrintHead { get; set; }
        public string ParamUnit { get; set; }
        public string ParamMethod { get; set; }
        public decimal? ParamRate { get; set; }
        public string ParamMaleNormal { get; set; }
        public string ParamFemaleNormal { get; set; }
        public string ParamChild1Normal { get; set; }
        public string ParamChild6Normal { get; set; }
        public string ParamChildNormal { get; set; }
        public string ParamMaleDef { get; set; }
        public string ParamFemaleDef { get; set; }
        public string ParamChild1Def { get; set; }
        public string ParamChild6Def { get; set; }
        public string ParamChildDef { get; set; }
        public float? ParamMaleHigh { get; set; }
        public float? ParamFemaleHigh { get; set; }
        public float? ParamChild1High { get; set; }
        public float? ParamChild6High { get; set; }
        public float? ParamChildHigh { get; set; }
        public float? ParamMaleLow { get; set; }
        public float? ParamFemaleLow { get; set; }
        public float? ParamChild1Low { get; set; }
        public float? ParamChild6Low { get; set; }
        public float? ParamChildLow { get; set; }
        public string ParamValidFlag { get; set; }
        public string ParamDef2 { get; set; }
        public string ParamFooter { get; set; }
        public float? SampleType { get; set; }
        public string Suffix { get; set; }
        public short? PPrecision { get; set; }
        public string Sendsms { get; set; }
        public string Formula { get; set; }
        public string Dc { get; set; }
        public string ParamType { get; set; }
    }
}
