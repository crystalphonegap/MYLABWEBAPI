using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortalWebApi.Models
{
    public class ErrorModel
    {
        public long Id { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime? Date { get; set; }

    }
}
