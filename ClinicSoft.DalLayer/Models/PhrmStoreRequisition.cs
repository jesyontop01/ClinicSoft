using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmStoreRequisition
    {
        public PhrmStoreRequisition()
        {
            PhrmStoreDispatchItems = new HashSet<PhrmStoreDispatchItem>();
        }

        public int RequisitionId { get; set; }
        public DateTime? RequisitionDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? RequisitionStatus { get; set; }
        public int StoreId { get; set; }
        public int RequisitionNo { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int FiscalYearId { get; set; }

        public virtual PhrmCfgFiscalYear FiscalYear { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<PhrmStoreDispatchItem> PhrmStoreDispatchItems { get; set; }
    }
}
