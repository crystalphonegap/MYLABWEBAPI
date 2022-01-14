using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class ProfileTestModel
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
        public bool Selected { get; set; }
        public string UserId { get; set; }
        public List<PathalogyTestDetails> PathalogyTestDetails { get; set; }
        public List<ProfileTestFormatDetails> TestFormatDetails { get; set; }
    }

    public class ProfileTestFormatDetails
    {
        public int TESTMST_CurrentId { get; set; }
        public string TESTMST_Name { get; set; }
        public int TEST_FormatSrNo { get; set; }
        public string TEST_sDefault { get; set; }
    }
}
