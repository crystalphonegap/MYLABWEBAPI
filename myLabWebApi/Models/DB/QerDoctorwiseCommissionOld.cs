using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerDoctorwiseCommissionOld
    {
        public int? DochdrLPatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? DochdrLDoctorId { get; set; }
        public string DoctorName { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string TestmstName { get; set; }
        public double? DochdrRate { get; set; }
        public bool DochdrBCommission { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string TestmstCattype { get; set; }
        public double? Discount { get; set; }
        public double? Comm { get; set; }
        public double? XComm { get; set; }
        public double? SComm { get; set; }
        public double? RComm { get; set; }
        public double? PfComm { get; set; }
        public double? SpComm { get; set; }
        public double? MComm { get; set; }
        public double? OComm { get; set; }
        public double? HcComm { get; set; }
        public double? ExComm { get; set; }
        public double? Ex1Comm { get; set; }
        public int? DochdrSample { get; set; }
        public string CenterName { get; set; }
        public double? LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
    }
}
