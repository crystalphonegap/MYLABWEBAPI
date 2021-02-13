﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PAIT_HDR_DET_TEST
    {
        public int Patient_Id { get; set; }
        public string LabSeriesSetting { get; set; }
        public int Patientno { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_SendSms { get; set; }
        public string PATIENT_VisitTime { get; set; }
        public string PATIENT_Email { get; set; }
        public string Patient_DocType { get; set; }
        public int CollectionCenterId { get; set; }
        public string PATIENT_Country { get; set; }
        public string PATIENT_PaymentMode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public string PATIENT_Date { get; set; }
        public int PATIENT_Doctorid { get; set; }
        public string PATIENT_DoctorName { get; set; }
        public int PATIENT_Companyid { get; set; }
        public string PATIENT_AmountPaid { get; set; }
        public int PATIENT_SampleCollected { get; set; }
        public int Doctorid2 { get; set; }
        public string DoctorName2 { get; set; }
        public string CENTER_Name { get; set; }
        public bool blnCommission { get; set; }
        public int labno { get; set; }
        public string WardNo { get; set; }
        public string HOSPTYPE { get; set; }
        public string TotalAmount { get; set; }
        public string EmergencyCharges { get; set; }
        public string Discount { get; set; }
        public string EmergencyChargesPecent { get; set; }
        public string Sample_Date { get; set; }
        public string PATIENT_DOB { get; set; }
        public string Remarks { get; set; }
        public string DiscountPercent { get; set; }
        public string PATIENT_AgeFlag { get; set; }
        public string CreatedDate { get; set; }
        public string username { get; set; }
        public string TEST_ALIAS { get; set; }
        public int Bar_Copiese { get; set; }
        public int Urgent { get; set; }
        public bool Issent { get; set; }
        public bool PrintUrgent { get; set; }
        public string Patient_key { get; set; }
        public string AppointmentId { get; set; }
        public string TEST { get; set; }
        public string Remark { get; set; }
        public string Paymode { get; set; }
        public string UPI_WalletAmount { get; set; }
        public string ChequeAmount { get; set; }
        public string CreditCardAmount { get; set; }
        public string NEFT_RTGSAmount { get; set; }
        public string CashAmount { get; set; }

        public string OtherRemarks { get; set; }



        public int TestId { get; set; }
        public string TESTMST_Name { get; set; }
        public decimal BaseRate { get; set; }
        public decimal Referal_Fee { get; set; }
        public decimal Discount1 { get; set; }
        public decimal TestRate { get; set; }
        public decimal LumSumAmt { get; set; }
        public string SpecialTest { get; set; }
        public string Type { get; set; }
        public int CENTER_id { get; set; }

        public long ID { get; set; }
        public int DOCDET_lHeaderId { get; set; }
        public int DOCDET_lFieldNo { get; set; }
        public string DOCDET_tFieldValue { get; set; }
        public int DOCDET_lTestCatId { get; set; }
        public string DOCDET_tFieldValue1 { get; set; }
        public bool isResRec { get; set; }
        public bool Rerun { get; set; }
        public string NormalValue { get; set; }
        public string sUnit { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float MinLimit { get; set; }
        public float MaxLimit { get; set; }
        public string Low_High { get; set; }
        public string ValueForNormal { get; set; }
        public int DOCHDR_lDocumentId { get; set; }
        public string DOCHDR_sDocNo { get; set; }
        public long DOCHDR_lPatientId { get; set; }
        public int DOCHDR_lDoctorId { get; set; }
        public string DOCHDR_sDescription { get; set; }
        public DateTime DOCHDR_dDate { get; set; }
        public int DOCHDR_TestCatID { get; set; }
        public string DOCHDR_Sex { get; set; }
        public string DOCHDR_Age { get; set; }
        public int DOCHDR_Sample { get; set; }
        public decimal DOCHDR_Rate { get; set; }
        public bool DOCHDR_bCommission { get; set; }
        public int DOCHDR_lEmployeeId { get; set; }
        public int NoOfPrintOuts { get; set; }
        public string MarkComplete { get; set; }
        public DateTime Currentdate { get; set; }
        public int ProfileId { get; set; }
        public string IsProfile { get; set; }
        public string DOCHDR_AgeFlag { get; set; }
        public string DOCHDR_PID { get; set; }
        public bool issent { get; set; }
        public bool issampleReceived { get; set; }
        public bool isAllResRec { get; set; }
        public DateTime RegistationDate { get; set; }
        public string RegistationUser { get; set; }
        public DateTime SampleReceivedDate { get; set; }
        public string SampleReceivedUser { get; set; }
        public DateTime DataEntryDate { get; set; }
        public string DataEntryUser { get; set; }
        public DateTime ValidateDate { get; set; }
        public string ValidateUser { get; set; }
        public DateTime ResampleDate { get; set; }
        public string ResampleUser { get; set; }
        public DateTime RerunDate { get; set; }
        public string RerunUser { get; set; }
        public DateTime AuntheticateDate { get; set; }
        public string AuthenticateUser { get; set; }
        public DateTime PrintDate { get; set; }
        public string PrintUser { get; set; }
        public DateTime PDFDate { get; set; }
        public string PDFUser { get; set; }
        public DateTime EmailDate { get; set; }
        public string EmailUser { get; set; }
        public string SampleReceivedRemark { get; set; }
        public string Lable_Sample { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestUser { get; set; }
        public DateTime IntegrationDate { get; set; }
    }
}
