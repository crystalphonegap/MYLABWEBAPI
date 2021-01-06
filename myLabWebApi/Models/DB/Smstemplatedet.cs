using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class SMSTEMPLATEDET
    {
        public int TemplateDetailId { get; set; }
        public int TemplateId { get; set; }
        public int TestId { get; set; }
        public int FieldNo { get; set; }
        public string IsList { get; set; }
        public double MinVal { get; set; }
        public double MaxVal { get; set; }
        public string ListValue { get; set; }
    }
}
