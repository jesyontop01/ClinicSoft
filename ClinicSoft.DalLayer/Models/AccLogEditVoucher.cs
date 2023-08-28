using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccLogEditVoucher
    {
        public int LogId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? SectionId { get; set; }
        public string? VoucherNumber { get; set; }
        public string? Reason { get; set; }
        public string? OldVocherJsonData { get; set; }
        public string? FiscalYearId { get; set; }
        public string? HospitalId { get; set; }
        public string? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
