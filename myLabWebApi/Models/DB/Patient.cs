﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class Patient
    {
        public long PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientAddress1 { get; set; }
        public string PatientAddress2 { get; set; }
        public string PatientCity { get; set; }
        public string PatientState { get; set; }
        public string PatientRegion { get; set; }
        public long PatientCountry { get; set; }
        public string PatientPincode { get; set; }
        public string PatientTelno { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public DateTime? PatientDate { get; set; }
        public int? PatientDoctorid { get; set; }
        public int? PatientCompanyid { get; set; }
        public double? PatientAmountPaid { get; set; }
        public int? PatientSampleCollected { get; set; }
        public int? Doctorid2 { get; set; }
        public string BlnCommission { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string Hosptype { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public DateTime? SampleDate { get; set; }
        public string Remarks { get; set; }
        public string Userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? Patientno { get; set; }
        public double? DiscountPercent { get; set; }
        public string PatientAgeFlag { get; set; }
        public string TestAlias { get; set; }
        public int? BarCopiese { get; set; }
        public int? Urgent { get; set; }
        public bool Issent { get; set; }
        public bool? PrintUrgent { get; set; }
        public string PatientKey { get; set; }
        public string PatientEmail { get; set; }
        public string AppointmentId { get; set; }
        public object UserCodetxt { get; internal set; }
        public object LabSeriesSetting { get; internal set; }
        public object MobileNo { get; internal set; }
        public object PATIENTPERMANENTID { get; internal set; }
        public object TEST { get; internal set; }
        public object DOB { get; internal set; }
        public object PATIENTNORMAL { get; internal set; }
        public object PATIENTSeniorCitizen { get; internal set; }
        public object IsBILL { get; internal set; }
        public object Result { get; internal set; }
        public object PATIENTDiabetic { get; internal set; }
    }
}
