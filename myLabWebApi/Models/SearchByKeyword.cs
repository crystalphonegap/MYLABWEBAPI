using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class SearchByKeyword
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
    }
}
