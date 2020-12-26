using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Users
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public int? CompanyId { get; set; }
    }
}
