using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class TreeView
    {
        public int? id { get; set; }
        public string title { get; set; }
        public int? parentid { get; set; }
    }
}
