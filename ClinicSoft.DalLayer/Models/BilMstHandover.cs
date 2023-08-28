using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilMstHandover
    {
        public BilMstHandover()
        {
            BilTxnDenominations = new HashSet<BilTxnDenomination>();
        }

        public int HandoverId { get; set; }
        public int? UserId { get; set; }
        public int? CounterId { get; set; }
        public string? HandoverType { get; set; }
        public int? HandoverUserId { get; set; }
        public double? PreviousAmount { get; set; }
        public double? HandoverAmount { get; set; }
        public double? TotalAmount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<BilTxnDenomination> BilTxnDenominations { get; set; }
    }
}
