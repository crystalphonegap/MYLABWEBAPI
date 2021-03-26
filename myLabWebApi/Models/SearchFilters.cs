using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class SearchFilters
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
    }
    public class SearchByKeywordPageNoPageSizeType
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
        public string Type { get; set; }
    }
    public class SearchByKeyword
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
    }

    public class SearchByKeywordType
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string KeyWord { get; set; }
        public string Type { get; set; }
    }
}
