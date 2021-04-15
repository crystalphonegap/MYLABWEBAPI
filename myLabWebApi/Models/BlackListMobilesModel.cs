using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class BlackListMobilesModel
    {
        public int BlacklistId { get; set; }
        public string Mobile { get; set; }
        public string sysDate { get; set; }
        public string sysUserName { get; set; }
    }
}
