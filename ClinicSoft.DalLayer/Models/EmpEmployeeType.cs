using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class EmpEmployeeType
    {
        public EmpEmployeeType()
        {
            EmpEmployees = new HashSet<EmpEmployee>();
        }

        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeName { get; set; } = null!;
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<EmpEmployee> EmpEmployees { get; set; }
    }
}
