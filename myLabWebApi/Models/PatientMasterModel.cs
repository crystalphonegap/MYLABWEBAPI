using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class PatientMasterModel
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
        public DateTime PATIENT_Date { get; set; }
        public int PATIENT_Doctorid { get; set; }
        public int PATIENT_Companyid { get; set; }
        public decimal PATIENT_AmountPaid { get; set; }
        public int PATIENT_SampleCollected { get; set; }
        public int Doctorid2 { get; set; }
        public bool blnCommission { get; set; }
        public int labno { get; set; }
        public string WardNo { get; set; }
        public string HOSPTYPE { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal EmergencyCharges { get; set; }
        public decimal Discount { get; set; }
        public decimal EmergencyChargesPecent { get; set; }
        public DateTime Sample_Date { get; set; }
        public DateTime PATIENT_DOB { get; set; }
        public string Remarks { get; set; }
        public decimal DiscountPercent { get; set; }
        public string PATIENT_AgeFlag { get; set; }
        public DateTime CreatedDate { get; set; }
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
        public decimal UPI_WalletAmount { get; set; }
        public decimal ChequeAmount { get; set; }
        public decimal CreditCardAmount { get; set; }
        public decimal NEFT_RTGSAmount { get; set; }

        public string OtherRemarks { get; set; }
    }
}
