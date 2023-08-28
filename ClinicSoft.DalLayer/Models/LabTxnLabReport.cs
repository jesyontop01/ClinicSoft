using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabTxnLabReport
    {
        public int LabReportId { get; set; }
        public int PatientId { get; set; }
        public int? TemplateId { get; set; }
        public DateTime ReceivingDate { get; set; }
        public DateTime ReportingDate { get; set; }
        public bool? IsPrinted { get; set; }
        public string? Signatories { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ReferredByDr { get; set; }
        public string? Comments { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
    }
}
