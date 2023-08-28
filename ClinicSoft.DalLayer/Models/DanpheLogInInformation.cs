using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class DanpheLogInInformation
    {
        public int InformationId { get; set; }
        public int? EmployeeId { get; set; }
        public string? UserName { get; set; }
        public string? ActionName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
