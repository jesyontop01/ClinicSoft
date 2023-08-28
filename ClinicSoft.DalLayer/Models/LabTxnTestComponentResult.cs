using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabTxnTestComponentResult
    {
        public long TestComponentResultId { get; set; }
        public long RequisitionId { get; set; }
        public long? LabTestId { get; set; }
        public string? ComponentName { get; set; }
        public string? Value { get; set; }
        public string? Unit { get; set; }
        public string? Range { get; set; }
        public string? Remarks { get; set; }
        public int? TemplateId { get; set; }
        public string? Method { get; set; }
        public string? RangeDescription { get; set; }
        public bool? IsNegativeResult { get; set; }
        public string? NegativeResultText { get; set; }
        public bool? IsAbnormal { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? LabReportId { get; set; }
        public bool? IsActive { get; set; }
        public string? AbnormalType { get; set; }
        public int? ResultGroup { get; set; }
        public int? ComponentId { get; set; }

        public virtual LabLabTest? LabTest { get; set; }
        public virtual LabTestRequisition Requisition { get; set; } = null!;
    }
}
