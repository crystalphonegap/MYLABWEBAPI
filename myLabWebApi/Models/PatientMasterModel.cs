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
        public DateTime Sample_Date { get; set; }
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
    }
}
