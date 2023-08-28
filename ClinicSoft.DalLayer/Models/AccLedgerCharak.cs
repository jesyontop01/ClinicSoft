using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccLedgerCharak
    {
        public double? Coacode { get; set; }
        public string? Coa { get; set; }
        public double? LedgerGroupCode { get; set; }
        public string? LedgerGroupName { get; set; }
        public double? LedgerCode { get; set; }
        public string? LedgerName { get; set; }
        public double? Opening { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public double? Closing { get; set; }
        public string? MigrationStatus { get; set; }
    }
}
