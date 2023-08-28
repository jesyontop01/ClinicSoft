using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class OtTxnSummary
    {
        public int OtsummaryId { get; set; }
        public int OtteamId { get; set; }
        public int OtbookingId { get; set; }
        public string? PreOperationDiagnosis { get; set; }
        public string? PostOperationDiagnosis { get; set; }
        public string? Anesthesia { get; set; }
        public double? Otcharge { get; set; }
        public string? Otdescription { get; set; }
        public string? Category { get; set; }
        public string? SignatureOfNurse { get; set; }

        public virtual OtTxnBookingDetail Otbooking { get; set; } = null!;
    }
}
