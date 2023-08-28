using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilBillItemRequisition
    {
        public long BillItemRequisitionId { get; set; }
        public long? RequisitionId { get; set; }
        public string BillStatus { get; set; } = null!;
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int ProviderId { get; set; }
        public int ServiceDepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public double Quantity { get; set; }
        public string? ProcedureCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? AssignedTo { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit PatientVisit { get; set; } = null!;
        public virtual EmpEmployee Provider { get; set; } = null!;
        public virtual BilMstServiceDepartment ServiceDepartment { get; set; } = null!;
    }
}
