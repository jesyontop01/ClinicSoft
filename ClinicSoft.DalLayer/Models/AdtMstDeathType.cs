using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstDeathType
    {
        public int DeathTypeId { get; set; }
        public string? DeathType { get; set; }
        public int? DischargeTypeId { get; set; }

        public virtual AdtDischargeType? DischargeType { get; set; }
    }
}
