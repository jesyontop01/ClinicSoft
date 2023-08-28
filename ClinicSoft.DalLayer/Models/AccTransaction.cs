using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTransaction
    {
        public AccTransaction()
        {
            AccTransactionItems = new HashSet<AccTransactionItem>();
            AccTxnLinks = new HashSet<AccTxnLink>();
            AccTxnPayments = new HashSet<AccTxnPayment>();
        }

        public int TransactionId { get; set; }
        public int? VoucherId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int FiscalYearId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? Remarks { get; set; }
        public int? SectionId { get; set; }
        /// <summary>
        /// It like hospital code with transaction id i.e. HAMS_TransactionId , 
        /// It will be null when comes from inventory
        /// </summary>
        public string? VoucherNumber { get; set; }
        public int? VoucherHeadId { get; set; }
        public bool? IsBackDateEntry { get; set; }
        public string? TransactionType { get; set; }
        public int? Tuid { get; set; }
        public int? DayVoucherNumber { get; set; }
        public bool IsCustomVoucher { get; set; }
        public bool? IsReverseTxnAllow { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsGroupTxn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? HospitalId { get; set; }
        public int? VoucherSerialNo { get; set; }
        public string? NewVoucherNumber { get; set; }
        public string? OldVoucherNumber { get; set; }
        public bool? IsAllowReverseVoucher { get; set; }
        public string? PayeeName { get; set; }
        public int? ChequeNumber { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
        public virtual AccMstVoucher? Voucher { get; set; }
        public virtual ICollection<AccTransactionItem> AccTransactionItems { get; set; }
        public virtual ICollection<AccTxnLink> AccTxnLinks { get; set; }
        public virtual ICollection<AccTxnPayment> AccTxnPayments { get; set; }
    }
}
