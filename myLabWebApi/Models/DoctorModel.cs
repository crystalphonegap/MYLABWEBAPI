﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class DoctorModel
    {
        public int DOCTOR_id { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Address1 { get; set; }
        public string DOCTOR_Address2 { get; set; }
        public string DOCTOR_City { get; set; }
        public string DOCTOR_State { get; set; }
        public string DOCTOR_Region { get; set; }
        public string DOCTOR_Country { get; set; }
        public string DOCTOR_Pincode { get; set; }
        public string DOCTOR_Telno { get; set; }

        public string DOCTOR_MobileNo { get; set; }
        public string DOCTOR_Email { get; set; }
        public string DOCTOR_Qualification { get; set; }
        public string OFFICE_Address1 { get; set; }

        public string OFFICE_Address2 { get; set; }
        public string OFFICE_City { get; set; }

        public string OFFICE_State { get; set; }
        public string OFFICE_Region { get; set; }
        public string OFFICE_Country { get; set; }

        public string OFFICE_Pincode { get; set; }

        public string OFFICE_Telno { get; set; }

        public string OFFICE_url { get; set; }

        public float DOCTOR_Commission { get; set; }

        public int DOCTOR_Companyid { get; set; }

        public string DOCTOR_Permanent { get; set; }

        public float DOCTOR_XCommission { get; set; }

        public float DOCTOR_SCommission { get; set; }

        public float DOCTOR_RCommission { get; set; }

        public float DOCTOR_PFCommission { get; set; }

        public float DOCTOR_SPCommission { get; set; }

        public float DOCTOR_MCommission { get; set; }

        public float DOCTOR_OCommission { get; set; }

        public float DOCTOR_HCommission { get; set; }

        public float DOCTOR_EXCommission { get; set; }

        public float DOCTOR_EX1Commission { get; set; }

        public int SendSMS { get; set; }

        public string DOCTOR_UserName { get; set; }

        public string DOCTOR_Password { get; set; }

        public string Password { get; set; }

        public DateTime DOB { get; set; }

        public string doctor_Code { get; set; }


    }
}
