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
        public string Keyword { get; set; }

        public string FromDate { get; set; }
        public string ToDate  { get; set; }
    }
    public class SearchByKeywordPageNoPageSizeType
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Keyword { get; set; }
        public string Type { get; set; }
    }
    public class SearchByKeywordType
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Keyword { get; set; }
        public string Type { get; set; }

    }
    public class GlobalDeleteModal
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class SearchFilters_Patient_REPORT
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public string Keyword { get; set; }

        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string UserId { get; set; }
    }

}
