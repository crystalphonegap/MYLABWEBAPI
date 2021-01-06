using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class USERS
    {
        public int Userid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool admin { get; set; }
        public int? Company_Id { get; set; }
    }
}
