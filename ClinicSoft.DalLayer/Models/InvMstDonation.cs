using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstDonation
    {
        public InvMstDonation()
        {
            InvTxnGoodsReceipts = new HashSet<InvTxnGoodsReceipt>();
        }

        public int DonationId { get; set; }
        public string? Donation { get; set; }
        public string? DonationPersonName { get; set; }
        public string? DonationDetails { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<InvTxnGoodsReceipt> InvTxnGoodsReceipts { get; set; }
    }
}
