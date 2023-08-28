using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class FrcPercentSetting
    {
        public FrcPercentSetting()
        {
            FrcFractionCalculations = new HashSet<FrcFractionCalculation>();
        }

        public int PercentSettingId { get; set; }
        public int BillItemPriceId { get; set; }
        public decimal? HospitalPercent { get; set; }
        public decimal? DoctorPercent { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }

        public virtual BilCfgBillItemPrice BillItemPrice { get; set; } = null!;
        public virtual ICollection<FrcFractionCalculation> FrcFractionCalculations { get; set; }
    }
}
