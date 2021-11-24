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
        public List<LabelgroupDetails> LabelgroupDetails { get; set; }
        public int GRPID { get; set; }
        public string GRPNAME { get; set; }
        public string Active { get; set; }
        public int Companyid { get; set; }
        public string Prefix { get; set; }
    }

    public class LabelgroupDetails
    {
        public int AutoId { get; set; }
        public int GRPID { get; set; }
        public int TESTID { get; set; }

    }
}
