using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstVoucher
    {
        public AccMstVoucher()
        {
            AccTransactions = new HashSet<AccTransaction>();
        }

        public int VoucherId { get; set; }
        public string? VoucherName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? VoucherCode { get; set; }
        public bool IscopyDescription { get; set; }
        public bool? ShowPayeeName { get; set; }
        public bool? ShowChequeNumber { get; set; }

        public virtual ICollection<AccTransaction> AccTransactions { get; set; }
    }
}
