using System;
using System.Collections.Generic;

namespace myLabWebApi.Models.New
{
    public partial class EmployeeWithCollectionCenterMap
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeContact { get; set; }
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public DateTime SysDatetime { get; set; }
    }
}
