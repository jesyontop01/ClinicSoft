using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgFiscalYear
    {
        public BilCfgFiscalYear()
        {
            BilTxnInvoiceReturns = new HashSet<BilTxnInvoiceReturn>();
            MatTxnPatientPayments = new HashSet<MatTxnPatientPayment>();
        }

        public int FiscalYearId { get; set; }
        public string FiscalYearName { get; set; } = null!;
        public string FiscalYearFormatted { get; set; } = null!;
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<BilTxnInvoiceReturn> BilTxnInvoiceReturns { get; set; }
        public virtual ICollection<MatTxnPatientPayment> MatTxnPatientPayments { get; set; }
    }
}
