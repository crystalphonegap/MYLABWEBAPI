using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class TreeView
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public int? Parentid { get; set; }
    }
}
