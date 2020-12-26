using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class BillHeader
    {
        public long BillId { get; set; }
        public long BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public string FinYear { get; set; }
        public int CenterId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Addition { get; set; }
        public decimal Deduction { get; set; }
        public int ServiceTaxPer { get; set; }
        public decimal ServiceTax { get; set; }
        public int CessPer { get; set; }
        public decimal Cess { get; set; }
        public int HsCessPer { get; set; }
        public decimal Hscess { get; set; }
        public decimal Total { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsTdsCertificateRec { get; set; }
        public string TdsCertificateRecNo { get; set; }
        public DateTime? TdsCertificateRecDate { get; set; }
        public string BillType { get; set; }
    }
}
