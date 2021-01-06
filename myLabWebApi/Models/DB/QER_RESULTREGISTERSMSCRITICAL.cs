using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class QER_RESULTREGISTERSMSCRITICAL
    {
        public int? TESTDET_TestMasterID { get; set; }
        public int? TESTDET_FieldNo { get; set; }
        public string TESTMST_Name { get; set; }
        public string TESTDET_FieldName { get; set; }
        public string TESTDET_sAlias { get; set; }
        public int? TESTMST_ID { get; set; }
        public string TESTDET_sUnit { get; set; }
        public double? TESTDET_MaxLimit { get; set; }
        public double? TESTDET_MinLimit { get; set; }
    }
}
