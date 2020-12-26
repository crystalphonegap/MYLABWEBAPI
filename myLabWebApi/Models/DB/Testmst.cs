using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Testmst
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
        public string IsKitImageCompulsary { get; set; }
        public int? Tat { get; set; }
        public string IsNabl { get; set; }
    }
}
