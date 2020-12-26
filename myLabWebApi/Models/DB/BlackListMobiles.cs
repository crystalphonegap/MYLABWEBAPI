using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class BlackListMobiles
    {
        public int BlacklistId { get; set; }
        public string Mobile { get; set; }
        public DateTime? SysDate { get; set; }
        public string SysUserName { get; set; }
    }
}
