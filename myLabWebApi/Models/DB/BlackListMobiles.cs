using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class BlackListMobiles
    {
        public int BlacklistId { get; set; }
        public string Mobile { get; set; }
        public DateTime? sysDate { get; set; }
        public string sysUserName { get; set; }
    }
}
