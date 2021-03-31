using System.Collections.Generic;

namespace myLabWebApi.Models
{
    public class PathalogyTestMaster
    {
        public string TESTMST_CurrentId { get; set; }
        public string TESTMST_Name { get; set; }
        public string TESTMST_PrintFormat { get; set; }
        public string TESTMST_Rate { get; set; }
        public string TESTMST_ReportHeading { get; set; }
        public string Type { get; set; }
        public string TESTMST_Testcost { get; set; }
        public string TESTMST_Alias { get; set; }
        public string TESTMST_Percentage { get; set; }
        public string TESTMST_Lumsum { get; set; }
        public bool Active { get; set; }
        public string Comments { get; set; }
        public string TESTMST_Companyid { get; set; }
        public string TESTMST_TestTypeId { get; set; }
        public string TESTMST_CatType { get; set; }
        public bool SpecialTest { get; set; }
        public string TESTMST_sample { get; set; }
        public bool IsKitImageCompulsary { get; set; }
        public string TAT { get; set; }
        public bool IsNABL { get; set; }
        public List<PathalogyTestDetails> PathalogyTestDetails { get; set; }
    }
}