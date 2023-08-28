using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstDischargeConditionType
    {
        public AdtMstDischargeConditionType()
        {
            AdtMstDeliveryTypes = new HashSet<AdtMstDeliveryType>();
        }

        public int DischargeConditionId { get; set; }
        public int DischargeTypeId { get; set; }
        public string? Condition { get; set; }

        public virtual AdtDischargeType DischargeType { get; set; } = null!;
        public virtual ICollection<AdtMstDeliveryType> AdtMstDeliveryTypes { get; set; }
    }
}
