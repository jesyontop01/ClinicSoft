using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnFixedAssetReturn
    {
        public InvTxnFixedAssetReturn()
        {
            InvTxnFixedAssetReturnItems = new HashSet<InvTxnFixedAssetReturnItem>();
        }

        public int ReturnId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? SubStoreId { get; set; }
        public int? StoreId { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual ICollection<InvTxnFixedAssetReturnItem> InvTxnFixedAssetReturnItems { get; set; }
    }
}
