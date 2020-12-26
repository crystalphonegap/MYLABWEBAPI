using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.DB
{
    public partial class HomevisitImage
    {
        public int Id { get; set; }
        public string HomeVisitId { get; set; }
        public string ImageString { get; set; }
    }
}
