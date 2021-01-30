using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PathalogyTestMaster
    {
        public int TESTMST_CurrentId { get;set;}
        public string TESTMST_Name { get;set;}
        public string TESTMST_PrintFormat { get;set;}
        public decimal TESTMST_Rate { get; set; }
        public string TESTMST_ReportHeading { get; set; }
        public string Type { get; set; }
        public decimal TESTMST_Testcost { get; set; }
        public string TESTMST_Alias { get; set; }
        public string TESTMST_Percentage { get; set; }
        public decimal TESTMST_Lumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int TESTMST_Companyid { get; set; }
        public int TESTMST_TestTypeId { get; set; }
        public string TESTMST_CatType { get; set; }
        public string SpecialTest { get; set; }
        public string TESTMST_sample { get; set; }
        public string IsKitImageCompulsary { get; set; }
        public string TAT { get; set; }
        public string IsNABL { get; set; }
    }
}
