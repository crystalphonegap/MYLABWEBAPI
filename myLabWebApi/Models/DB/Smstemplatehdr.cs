using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class SMSTEMPLATEHDR
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string TemplateSMSName { get; set; }
        public int? ValidityDay { get; set; }
        public string SMSTemplate { get; set; }
        public DateTime? SysDate { get; set; }
        public string sysUserName { get; set; }
    }
}
