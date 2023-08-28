using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtDischargeCancel
    {
        public int DischargeCancelId { get; set; }
        public int PatientVisitId { get; set; }
        public int PatientAdmissionId { get; set; }
        public DateTime DischargedDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DischargedBy { get; set; }
        public int DischargeCancelledBy { get; set; }
        public string DischargeCancelNote { get; set; } = null!;
        public int BillingTransactionId { get; set; }
    }
}
