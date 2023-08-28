using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstMappingDetail
    {
        public int AccountingMappingDetailId { get; set; }
        public int? GroupMappingId { get; set; }
        public int? LedgerGroupId { get; set; }
        public bool? DrCr { get; set; }
        public string? Description { get; set; }

        public virtual AccMstGroupMapping? GroupMapping { get; set; }
        public virtual AccMstLedgerGroup? LedgerGroup { get; set; }
    }
}
