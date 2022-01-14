using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class NarrationModel
    {
        public int NarrationId { get; set; }
        public string NarrationText { get; set; }
        public string UserId { get; set; }
    }
}
