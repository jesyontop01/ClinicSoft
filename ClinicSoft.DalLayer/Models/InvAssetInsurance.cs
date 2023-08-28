using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvAssetInsurance
    {
        public int AssetInsurannceId { get; set; }
        public int FixedAssetStockId { get; set; }
        public string? PolicyNumber { get; set; }
        public string? Insurer { get; set; }
        public string? InsuredValue { get; set; }
        public DateTime? InsuranceStartDate { get; set; }
        public DateTime? InsuranceEndDate { get; set; }
        public string? ComprehensiveInsurance { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual InvTxnFixedAssetStock FixedAssetStock { get; set; } = null!;
        public virtual EmpEmployee? ModifiedByNavigation { get; set; }
    }
}
