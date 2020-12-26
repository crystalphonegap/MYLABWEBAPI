using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerDoctorComm
    {
        public long PatientId { get; set; }
        public DateTime? PatientDate { get; set; }
        public string PatientName { get; set; }
        public double? PatientAmountPaid { get; set; }
        public int? PatientDoctorid { get; set; }
        public string DoctorName { get; set; }
        public double? DoctorCommission { get; set; }
        public double? DoctorXcommission { get; set; }
        public int? DoctorScommission { get; set; }
        public double? DoctorRcommission { get; set; }
        public double? DoctorPfcommission { get; set; }
        public double? DoctorSpcommission { get; set; }
        public double? DoctorMcommission { get; set; }
        public double? DoctorOcommission { get; set; }
        public double? DoctorHcommission { get; set; }
        public double? DoctorExcommission { get; set; }
        public double? DoctorEx1commission { get; set; }
        public string DochdrSDocNo { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? DochdrTestCatId { get; set; }
        public double? DochdrRate { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string TestmstName { get; set; }
        public string Type { get; set; }
        public int? PatientSampleCollected { get; set; }
        public string CenterName { get; set; }
    }
}
