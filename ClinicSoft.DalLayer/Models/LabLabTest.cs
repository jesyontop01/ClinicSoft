using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabLabTest
    {
        public LabLabTest()
        {
            LabMapTestComponents = new HashSet<LabMapTestComponent>();
            LabTestRequisitions = new HashSet<LabTestRequisition>();
            LabTxnTestComponentResults = new HashSet<LabTxnTestComponentResult>();
        }

        public long LabTestId { get; set; }
        public string? LabTestCode { get; set; }
        public string? LabTestName { get; set; }
        public string? LabTestSpecimen { get; set; }
        public string? LabTestSpecimenSource { get; set; }
        public int? ReportTemplateId { get; set; }
        public string? Description { get; set; }
        public bool? HasNegativeResults { get; set; }
        public string? NegativeResultText { get; set; }
        public string? ProcedureCode { get; set; }
        public string? LabTestSynonym { get; set; }
        public string? Loinc { get; set; }
        public bool? IsValidForReporting { get; set; }
        public int? LabSequence { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? DisplaySequence { get; set; }
        public string? ReportingName { get; set; }
        public string? Interpretation { get; set; }
        public string? RunNumberType { get; set; }
        public int? LabTestCategoryId { get; set; }
        public bool? SmsApplicable { get; set; }

        public virtual LabReportTemplate? ReportTemplate { get; set; }
        public virtual ICollection<LabMapTestComponent> LabMapTestComponents { get; set; }
        public virtual ICollection<LabTestRequisition> LabTestRequisitions { get; set; }
        public virtual ICollection<LabTxnTestComponentResult> LabTxnTestComponentResults { get; set; }
    }
}
