using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class LabelGroupModel
    {
        
    }
    public class LabelGroupMaster
    {
       
        public List<TestDetailsClass> TestDetailsClass { get; set; }
        public int GRPID { get; set; }
        public string GRPNAME { get; set; }
        public bool Active { get; set; }
        public int Companyid { get; set; }
        public string Prefix { get; set; }
        public string Action { get; set; }
        public int TotalRows { get; set; }
    }

    public class LabelgroupDetails
    {
        public int AutoId { get; set; }
        public int GRPID { get; set; }
        public int TESTID { get; set; }

    }

    public class TestDetailsClass
    {
        public int TestId { get; set; }
        public string  TestName { get; set; }

        public bool Selected { get; set; }
    }

    public class LabelGroupDetailsClass
    {
      
      
        public int TestId { get; set; }
        public string TestName { get; set; }
        public int GRPID { get; set; }
        public string GRPNAME { get; set; }
        public bool Active { get; set; }
        public int Companyid { get; set; }
        public string Prefix { get; set; }

    }
    }
