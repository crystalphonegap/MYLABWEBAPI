using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Predefval
    {
        public int? PredefvalId { get; set; }
        public int? PredefvalFieldid { get; set; }
        public int? PredefvalValNo { get; set; }
        public string PredefvalValue { get; set; }
    }
}
