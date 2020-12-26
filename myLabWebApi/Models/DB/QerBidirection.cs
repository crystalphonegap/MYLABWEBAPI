using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerBidirection
    {
        public int DochdrLDocumentId { get; set; }
        public string MarkComplete { get; set; }
        public string DochdrSDocNo { get; set; }
        public string PatientName { get; set; }
        public int? Labno { get; set; }
        public string DoctorName { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public string TestmstName { get; set; }
        public string TestmstPrintFormat { get; set; }
        public string Type { get; set; }
        public long? DochdrLPatientId { get; set; }
        public int? TestmstCurrentId { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string ProfileName { get; set; }
        public int? ProfileId { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public DateTime? SampleDate { get; set; }
        public string WardNo { get; set; }
    }
}
