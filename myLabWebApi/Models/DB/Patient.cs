using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models.DB
{
    public class Patient
    {
        public int PATIENT_id { get; set; }
        public string EMPLOYEE_Name { get; set; }
        public string PATIENT_Address1 { get; set; }
        public string PATIENT_Address2 { get; set; }
        public string PATIENT_City { get; set; }
        public string PATIENT_State { get; set; }
        public string PATIENT_Region { get; set; }
        public string PATIENT_Country { get; set; }
        public string PATIENT_Pincode { get; set; }
        public string PATIENT_Telno { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Age { get; set; }
        public DateTime PATIENT_Date { get; set; }
        public int PATIENT_Doctorid { get; set; }
        public int PATIENT_Companyid { get; set; }
        public int PATIENT_AmountPaid { get; set; }
        public int PATIENT_SampleCollected { get; set; }
        public int Doctorid2 { get; set; }
        public string blnCommission { get; set; }
        public int labno { get; set; }
        public string WardNo { get; set; }
        public string HOSPTYPE { get; set; }
        public int TotalAmount { get; set; }
        public int EmergencyCharges { get; set; }
        public int Discount { get; set; }
        public int EmergencyChargesPecent { get; set; }
        public DateTime Sample_Date { get; set; }
        public string Remarks { get; set; }
        public string userid { get; set; }
        public DateTime Currentdate { get; set; }
        public int Patientno { get; set; }
        public double? DiscountPercent { get; set; }
        public string PATIENT_AgeFlag { get; set; }
        public string TEST_ALIAS { get; set; }
        public int Bar_Copiese { get; set; }
        public int Urgent { get; set; }
        public int Issent { get; set; }
        public int? PrintUrgent { get; set; }
        public string Patient_key { get; set; }
        public string PATIENT_Email  { get; set; }
        public string AppointmentId { get; set; }
    }
}
