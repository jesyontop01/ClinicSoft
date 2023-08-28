using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmWriteOff
    {
        public PhrmWriteOff()
        {
            PhrmWriteOffItems = new HashSet<PhrmWriteOffItem>();
        }

        public int WriteOffId { get; set; }
        public DateTime? WriteOffDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? WriteOffRemark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsTransferredToAcc { get; set; }
        public int? StoreId { get; set; }
        public int? WriteOffNo { get; set; }

        public virtual EmpEmployee CreatedByNavigation { get; set; } = null!;
        public virtual PhrmMstStore? Store { get; set; }
        public virtual ICollection<PhrmWriteOffItem> PhrmWriteOffItems { get; set; }
    }
}
