﻿using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class CATEGORY
    {
        public int CatTypeId { get; set; }
        public string CatName { get; set; }
        public double? CatCommPer { get; set; }
        public string CatDescription { get; set; }
        public string CatRemark { get; set; }
        public string CatRemark1 { get; set; }
    }
}
