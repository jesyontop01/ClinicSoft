using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccLedgerMapping
    {
        public int LedgerMappingId { get; set; }
        public int? LedgerId { get; set; }
        public int? ReferenceId { get; set; }
        public string? LedgerType { get; set; }
        public int? HospitalId { get; set; }

        public virtual AccMstHospital? Hospital { get; set; }
    }
}
