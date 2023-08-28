using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTxnDenomination
    {
        public int DenominationId { get; set; }
        public int? HandoverId { get; set; }
        public int? CurrencyType { get; set; }
        public double? Quantity { get; set; }
        public double? Amount { get; set; }

        public virtual BilMstHandover? Handover { get; set; }
    }
}
