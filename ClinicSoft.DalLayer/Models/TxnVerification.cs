using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TxnVerification
    {
        public TxnVerification()
        {
            InvTxnRequisitions = new HashSet<InvTxnRequisition>();
            InverseParentVerification = new HashSet<TxnVerification>();
        }

        public int VerificationId { get; set; }
        public int VerifiedBy { get; set; }
        public DateTime VerifiedOn { get; set; }
        public int CurrentVerificationLevel { get; set; }
        public int MaxVerificationLevel { get; set; }
        public string VerificationStatus { get; set; } = null!;
        public int? ParentVerificationId { get; set; }
        public string? VerificationRemarks { get; set; }
        public int CurrentVerificationLevelCount { get; set; }

        public virtual TxnVerification? ParentVerification { get; set; }
        public virtual ICollection<InvTxnRequisition> InvTxnRequisitions { get; set; }
        public virtual ICollection<TxnVerification> InverseParentVerification { get; set; }
    }
}
