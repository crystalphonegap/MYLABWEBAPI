﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class QerForMypathtest
    {
        public int TestmstCurrentId { get; set; }
        public string TestmstName { get; set; }
        public string TestmstPrintFormat { get; set; }
        public double? TestmstRate { get; set; }
        public string TestmstReportHeading { get; set; }
        public string Type { get; set; }
        public double? TestmstTestcost { get; set; }
        public string TestmstAlias { get; set; }
        public double? TestmstPercentage { get; set; }
        public double? TestmstLumsum { get; set; }
        public string Active { get; set; }
        public string Comments { get; set; }
        public int? TestmstCompanyid { get; set; }
        public int? TestmstTestTypeId { get; set; }
        public string TestmstCatType { get; set; }
        public string SpecialTest { get; set; }
        public string TestmstSample { get; set; }
        public int TestdetCurrentId { get; set; }
        public int? TestdetTestMasterId { get; set; }
        public int? TestdetFieldNo { get; set; }
        public string TestdetFieldName { get; set; }
        public short? TestdetFieldType { get; set; }
        public string TestdetNormalValue { get; set; }
        public string TestdetDescription { get; set; }
        public string TestdetGroupName { get; set; }
        public int? TestdetGroupNo { get; set; }
        public short? TestdetFieldStyle { get; set; }
        public bool? TestdetCompulsory { get; set; }
        public double? TestdetMaxValue { get; set; }
        public double? TestdetMinValue { get; set; }
        public string TestdetSDefault { get; set; }
        public string TestdetSAlias { get; set; }
        public string TestdetSUnit { get; set; }
        public string TestdetSFormula { get; set; }
        public int? TestdetTestTypeId { get; set; }
        public int? TestdetCatTypeId { get; set; }
        public bool? TestdetValidate { get; set; }
        public double? TestdetMaxLimit { get; set; }
        public double? TestdetMinLimit { get; set; }
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
        public double? PatientAmountPaid { get; set; }
        public int? PatientSampleCollected { get; set; }
        public double? TotalAmount { get; set; }
        public double? EmergencyCharges { get; set; }
        public double? Discount { get; set; }
        public double? EmergencyChargesPecent { get; set; }
        public string Remarks { get; set; }
        public int? Patientno { get; set; }
        public int DochdrLDocumentId { get; set; }
        public string DochdrSDocNo { get; set; }
        public long? DochdrLPatientId { get; set; }
        public int? DochdrLDoctorId { get; set; }
        public string DochdrSDescription { get; set; }
        public DateTime? DochdrDDate { get; set; }
        public int? DochdrTestCatId { get; set; }
        public string DochdrSex { get; set; }
        public string DochdrAge { get; set; }
        public int? DochdrSample { get; set; }
        public double? DochdrRate { get; set; }
        public bool DochdrBCommission { get; set; }
        public int? DochdrLEmployeeId { get; set; }
        public string ValidateUser { get; set; }
        public short? NoOfPrintOuts { get; set; }
        public string MarkComplete { get; set; }
        public int? Doctorid2 { get; set; }
        public int? Labno { get; set; }
        public string WardNo { get; set; }
        public string Hosptype { get; set; }
        public DateTime? SampleDate { get; set; }
        public string Userid { get; set; }
        public DateTime? Currentdate { get; set; }
        public int? ProfileId { get; set; }
        public string IsProfile { get; set; }
        public string DochdrPid { get; set; }
        public int DocdetLHeaderId { get; set; }
        public int DocdetLFieldNo { get; set; }
        public string DocdetTFieldValue { get; set; }
        public int? DocdetLTestCatId { get; set; }
        public string DocdetTFieldValue1 { get; set; }
        public bool? Rerun { get; set; }
        public int? DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorAddress1 { get; set; }
        public string DoctorAddress2 { get; set; }
        public string DoctorCity { get; set; }
        public string DoctorState { get; set; }
        public string DoctorRegion { get; set; }
        public string DoctorCountry { get; set; }
        public string DoctorPincode { get; set; }
        public string DoctorTelno { get; set; }
        public string DoctorMobileNo { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorQualification { get; set; }
        public string OfficeAddress1 { get; set; }
        public string OfficeAddress2 { get; set; }
        public string OfficeCity { get; set; }
        public string OfficeState { get; set; }
        public string OfficeRegion { get; set; }
        public string OfficeCountry { get; set; }
        public string OfficePincode { get; set; }
        public string OfficeTelno { get; set; }
        public string OfficeUrl { get; set; }
        public double? DoctorCommission { get; set; }
        public int? DoctorCompanyid { get; set; }
        public string DoctorPermanent { get; set; }
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
        public string EmployeeName { get; set; }
        public string Doc2 { get; set; }
        public string CenterName { get; set; }
        public string Docq2 { get; set; }
        public byte[] Wbc { get; set; }
        public byte[] RbcHisto { get; set; }
        public byte[] Plt { get; set; }
        public string CompanyPathologist1 { get; set; }
        public string CompanyPathologist2 { get; set; }
        public string CompanyPathoDegree1 { get; set; }
        public string CompanyPathoDegree2 { get; set; }
        public long PatientId { get; set; }
        public int? PatientCompanyid { get; set; }
        public string CompanyRadiologist1 { get; set; }
        public string CompanyRadiologist2 { get; set; }
        public string CompanyRadDegree1 { get; set; }
        public string CompanyRadDegree2 { get; set; }
        public string CompanyCardiologist1 { get; set; }
        public string CompanyCardiologist2 { get; set; }
        public string CompanyCardDegree1 { get; set; }
        public string CompanyCardDegree2 { get; set; }
        public DateTime? PatientSample { get; set; }
    }
}
