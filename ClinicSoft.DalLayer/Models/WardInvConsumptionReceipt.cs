using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInvConsumptionReceipt
    {
        public WardInvConsumptionReceipt()
        {
            WardInvConsumptions = new HashSet<WardInvConsumption>();
        }

        public int ConsumptionReceiptId { get; set; }
        public int ConsumptionReceiptNo { get; set; }
        public DateTime ConsumptionDate { get; set; }
        public int PatientId { get; set; }
        public int StoreId { get; set; }
        public string? Remarks { get; set; }
        public bool? IsCancel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PhrmMstStore Store { get; set; } = null!;
        public virtual ICollection<WardInvConsumption> WardInvConsumptions { get; set; }
    }
}
