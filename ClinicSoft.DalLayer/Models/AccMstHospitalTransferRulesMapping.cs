using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstHospitalTransferRulesMapping
    {
        public int HospitalTransferRulesMapId { get; set; }
        public int? HospitalId { get; set; }
        public int? TransferRuleId { get; set; }
        public bool? IsActive { get; set; }
    }
}
