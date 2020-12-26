using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerTdscertificate
    {
        public long BillId { get; set; }
        public long BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string FinYear { get; set; }
        public int CenterId { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTdsCertificateRec { get; set; }
        public string TdsCertificateRecNo { get; set; }
        public DateTime? TdsCertificateRecDate { get; set; }
        public string CenterName { get; set; }
        public decimal? Tds { get; set; }
    }
}
