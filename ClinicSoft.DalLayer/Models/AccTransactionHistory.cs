using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTransactionHistory
    {
        public int Id { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? SyncedOn { get; set; }
        public int? SyncedBy { get; set; }
        public int? SectionId { get; set; }
        public string? TransactionType { get; set; }
    }
}
