using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmPrescriptionItem
    {
        public PhrmPrescriptionItem()
        {
            PhrmSaleItems = new HashSet<PhrmSaleItem>();
        }

        public int PrescriptionItemId { get; set; }
        public int? ItemId { get; set; }
        public double? Quantity { get; set; }
        public int? Frequency { get; set; }
        public DateTime? StartingDate { get; set; }
        public int? HowManyDays { get; set; }
        public string? Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? PatientId { get; set; }
        public int? ProviderId { get; set; }
        public string? OrderStatus { get; set; }
        public string? Dosage { get; set; }
        public int? GenericId { get; set; }
        public int? DiagnosisId { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual ClnDiagnosis? Diagnosis { get; set; }
        public virtual ICollection<PhrmSaleItem> PhrmSaleItems { get; set; }
    }
}
