using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstDepartment
    {
        public MstDepartment()
        {
            BilMstServiceDepartments = new HashSet<BilMstServiceDepartment>();
            EmpEmployees = new HashSet<EmpEmployee>();
            InvTxnRequisitions = new HashSet<InvTxnRequisition>();
            InverseParentDepartment = new HashSet<MstDepartment>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentCode { get; set; }
        public string DepartmentName { get; set; } = null!;
        public string? Description { get; set; }
        public int? DepartmentHead { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAppointmentApplicable { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ParentDepartmentId { get; set; }
        public string? RoomNumber { get; set; }
        public string? NoticeText { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual MstDepartment? ParentDepartment { get; set; }
        public virtual ICollection<BilMstServiceDepartment> BilMstServiceDepartments { get; set; }
        public virtual ICollection<EmpEmployee> EmpEmployees { get; set; }
        public virtual ICollection<InvTxnRequisition> InvTxnRequisitions { get; set; }
        public virtual ICollection<MstDepartment> InverseParentDepartment { get; set; }
    }
}
