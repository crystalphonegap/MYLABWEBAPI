using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class MYLAB_TEST_DETAILS
    {
        public int TEST_ID { get; set; }
        public string TEST_NAME { get; set; }
        public int MYLAB_TEST_MSTID { get; set; }
        public int MYLAB_TEST_FIELDNO_ONE { get; set; }
        public int? MYLAB_TEST_FIELDNO_TWO { get; set; }
        public string TYPE { get; set; }
        public long ID { get; set; }
    }
}
