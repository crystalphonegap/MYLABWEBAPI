using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Histogram
    {
        public int? DochdrLDocumentId { get; set; }
        public int? DochdrLPatientId { get; set; }
        public byte[] WbcHisto { get; set; }
        public byte[] RbcHisto { get; set; }
        public byte[] PltHisto { get; set; }
        public int? LabNo { get; set; }
        public DateTime? LabDate { get; set; }
        public string Status { get; set; }
        public decimal Srno { get; set; }
    }
}
