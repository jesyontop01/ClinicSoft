using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class DocTxnVisitSummary
    {
        public int VisitSummaryId { get; set; }
        public int? PatientId { get; set; }
        public int? VisitId { get; set; }
        public int? QnairId { get; set; }
        public int? QuestionId { get; set; }
        public string? Answer { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
