using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class EmployeeInfoModel
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Salutation { get; set; }
        public string? Designation { get; set; }
        public string? DepartmentName { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailId { get; set; }
        public string? Address { get; set; }
    }
}
