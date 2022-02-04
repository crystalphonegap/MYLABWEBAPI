using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class MailSettings
    {

        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public int SMTPPort { get; set; }
        public string WebSiteName { get; set; }

        public string DataSourceName { get; set; }

        public string MainDatabase { get; set; }
        public string MainDatabaseDataFileName { get; set; }
        public string MainDatabaseLogFileName { get; set; }
        public string MainDatabaseBackupFile { get; set; }
        public string TargetDatabaseBackupFileStorageLocation { get; set; }

        public string SMSUserName { get; set; }

        public string SMSSenderID { get; set; }

        public string SMSPassword { get; set; }

        public string SMSUrl { get; set; }
        public string WhatsAppUrl { get; set; }

        public string WhatsAppUserName { get; set; }

        public string WhatsAppPassword { get; set; }

        public string WhatsAppAPILinkforChat { get; set; }

        public string BitilityURL { get; set; }


    }
}
