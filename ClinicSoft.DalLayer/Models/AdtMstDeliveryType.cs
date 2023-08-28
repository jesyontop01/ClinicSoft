using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstDeliveryType
    {
        public int DeliveryTypeId { get; set; }
        public int DischargeConditionId { get; set; }
        public string? DeliveryTypeName { get; set; }

        public virtual AdtMstDischargeConditionType DischargeCondition { get; set; } = null!;
    }
}
