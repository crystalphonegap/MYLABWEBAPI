using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PatientMasterModel
    {
        public int Patient_Id { get; set; }
        public int CollectionCenterId { get; set; }
        public int PATIENT_Companyid { get; set; }
        public int PATIENT_Doctorid { get; set; }
        public int PATIENT_SampleCollected { get; set; }
        public int Doctorid2 { get; set; }
        public string labno { get; set; }
        public int Bar_Copiese { get; set; }
        public int Urgent { get; set; }
        public bool Issent { get; set; }
        public bool PrintUrgent { get; set; }
        public bool blnCommission { get; set; }

        public bool SendSMS { get; set; }

        public string LabSeriesSetting { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_SendSms { get; set; }
        public string PATIENT_VisitTime { get; set; }
        public string PATIENT_Email { get; set; }
        public string Patient_DocType { get; set; }
        public string PATIENT_Country { get; set; }
        public string PATIENT_PaymentMode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public string PATIENT_Date { get; set; }
        public string PATIENT_DoctorName { get; set; }
        public string PATIENT_AmountPaid { get; set; }
        public string DoctorName2 { get; set; }
        public string CENTER_Name { get; set; }
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

        public string FileName { get; set; }
        public int TPAId { get; set; }
        public string HospitalizeRemark { get; set; }


        public string City { get; set; }
        public string Area { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }

        public string State { get; set; }
        public string Pincode { get; set; }
        public string TelephoneNo { get; set; }
        public string SavedFileName { get; set; }
        public IFormFile FileUpload { get; set; }

        public int Status { get; set; }
        public string ProposalNumber { get; set; }


        public string TestStatus { get; set; }
        public string userid { get; set; }
        public decimal BillAmount { get; set; }
        public string BALANCE { get; set; }
    }
   
    public class DocumentClassModel
    {
        public List<IFormFile> files { get; set; }
        public string PatientId { get; set; }
        public string AddedBy { get; set; }
        public string MarkComplete { get; set; }
        public string TestId { get; set; }
    }

    public class LabNoClassModel
    {
        
        public string LabNumber { get; set; }
    }

    public  class RATELISTHDR_NEW
    {
        public int RateListId { get; set; }
        public string RateListName { get; set; }
        public DateTime SysDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string SysUser { get; set; }
        public double? Routine { get; set; }
        public double? Special { get; set; }
        public double? Microbiology { get; set; }
        public double Outside { get; set; }
        public double? Histo { get; set; }
        public double? other { get; set; }
        public double? other1 { get; set; }

        public string CollectionCenterName { get; set; }
        public string UserId { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }

        

    }
    public class AccountbookUserMasterModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public DateTime? RegDate { get; set; }
        public string RowSent { get; set; }
        public bool Flag { get; set; }
        public int LabID { get; set; }
        public string LabName { get; set; }
        public int CentrID { get; set; }

        public string LabCode { get; set; }
        public DateTime? Sys_Date { get; set; }

        public string NewPassword { get; set; }
        public virtual ICollection<RefreshToken> RefreshTokens { get; set; }

        // public string Flag { get; set; }
        public string BrowserName { get; set; }
        public string IpAddress { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public string Territory { get; set; }
        public string ResetTokenvtxt { get; set; }
        public int Userid { get; set; }
        public string MenuName { get; set; }
        public string labno { get; set; }
        public bool Flag1 { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        //public string LabName { get; set; }



    }

    public class Testtypelist
    {
        public int TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public string TestTypeDescription { get; set; }
        public string TestTypeRemark { get; set; }
        public string TestTypeRemark1 { get; set; }
        public string UserId { get; set; }
    }

}
