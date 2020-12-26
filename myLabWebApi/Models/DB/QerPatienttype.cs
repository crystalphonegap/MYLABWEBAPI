using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerPatienttype
    {
        public long PatientId { get; set; }
        public DateTime? PatientDate { get; set; }
        public string Name { get; set; }
        public string PatientRegion { get; set; }
        public long PatientCountry { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelno { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public int? PatientDoctorid { get; set; }
        public int? PatientCompanyid { get; set; }
        public double? PatientAmountPaid { get; set; }
        public string Type { get; set; }
        public int? AmountPaid { get; set; }
        public DateTime? CurrentDate { get; set; }
        public string Paymode { get; set; }
        public int? Labno { get; set; }
        public string Hosptype { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public DateTime? SampleDate { get; set; }
        public string Remarks { get; set; }
        public int? Patientno { get; set; }
        public string Userid { get; set; }
        public int? PatientSampleCollected { get; set; }
        public string CenterName { get; set; }
    }
}
