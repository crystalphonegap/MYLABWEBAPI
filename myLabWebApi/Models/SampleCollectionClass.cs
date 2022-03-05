using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabWebApi.Models
{
    public class SampleCollectionClass
    {
        public int Patient_Id { get; set; }
        public string PATIENT_Name { get; set; }
        public string labno { get; set; }
        public string PATIENT_Date { get; set; }
    }
    public class SampleCollectionClassSearchModel
    {
        public string TYPE { get; set; }
        public string FROMDAATE { get; set; }
        public string TODATE { get; set; }
        public string KEYWORD { get; set; }
    }
    public class PatientTestDetailsSampleCollection
    {
        public int Patient_Id { get; set; }
        public string labno { get; set; }
        public string PATIENT_Date { get; set; }
        public string PATIENT_Name { get; set; }
        public string PATIENT_Gender { get; set; }
        public string PATIENT_Telno { get; set; }

        public string CENTER_NAME { get; set; }
        public string DOCTOR_Name { get; set; }
        public string DOCTOR_Name2 { get; set; }
        public string TESTMST_CurrentId { get; set; }
        public string TESTMST_Name { get; set; }

        public string DOCHDR_lDocumentId { get; set; }
        public bool isSelected { get; set; }


    }
    public class SampleCollectionTestType
    {
        public string Id { get; set; }
        public string Name { get; set; }
      
    }

    public class SampleCollectionInsertClass
    {
        public string DOCHDRID { get; set; }
        public string PatientId { get; set; }
        public string Temprature { get; set; }
        public string TempratureStatus { get; set; }
        public string Remarks { get; set; }
        public bool LabelSampleReceived { get; set; }
        public bool ISDone { get; set; }
        public string USER { get; set; }

    }
}
