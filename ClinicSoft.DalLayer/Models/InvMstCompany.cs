using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstCompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? ContactNo { get; set; }
        public string? Description { get; set; }
        public string? ContactAddress { get; set; }
        public string? Email { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public string? Code { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
    }
}
