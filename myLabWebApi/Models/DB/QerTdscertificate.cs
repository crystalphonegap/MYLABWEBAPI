using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QerTDSCertificate
    {
        public long BillId { get; set; }
        public long BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string Fin_Year { get; set; }
        public int Center_Id { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTdsCertificateRec { get; set; }
        public string TdsCertificateRecNo { get; set; }
        public DateTime? TdsCertificateRecDate { get; set; }
        public string CENTER_Name { get; set; }
        public decimal? TDS { get; set; }
    }
}
