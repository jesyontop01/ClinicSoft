using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtDischargeSummaryMedication
    {
        public int DischargeSummaryMedicationId { get; set; }
        public int DischargeSummaryId { get; set; }
        /// <summary>
        /// OldNewMedicineType represents 1.New Medicines, 2. Old medicines to be continued, 3.Old medicines to be stopped
        /// </summary>
        public int? OldNewMedicineType { get; set; }
        public string? Medicine { get; set; }
        public int? FrequencyId { get; set; }
        public string? Notes { get; set; }
        public bool? IsActive { get; set; }
    }
}
