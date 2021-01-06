using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class TESTMST
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
        public string IsKitImageCompulsary { get; set; }
        public int? TAT { get; set; }
        public string IsNABL { get; set; }
    }
}
