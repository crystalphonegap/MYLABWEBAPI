using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Smstemplatehdr
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateSmsname { get; set; }
        public int? ValidityDay { get; set; }
        public string Smstemplate { get; set; }
        public DateTime? SysDate { get; set; }
        public string SysUserName { get; set; }
    }
}
