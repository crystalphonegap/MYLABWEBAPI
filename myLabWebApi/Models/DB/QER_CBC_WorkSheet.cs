using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_CBC_WorkSheet
    {
        public int? DOCHDR_lDocumentId { get; set; }
        public long PATIENT_id { get; set; }
        public string PATIENT_Name { get; set; }
        public int? DOCDET_lFieldNo { get; set; }
        public string DOCDET_tFieldValue { get; set; }
        public int? DOCHDR_TestCatID { get; set; }
        public string DOCHDR_Sex { get; set; }
        public string DOCHDR_Age { get; set; }
        public int? labno { get; set; }
        public DateTime? DOCHDR_dDate { get; set; }
        public string TESTDET_sAlias { get; set; }
        public string TESTDET_FieldName { get; set; }
        public int? DOCHDR_lDoctorId { get; set; }
    }
}
