using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTempItemPriceWithVat
    {
        public int? SerNo { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? ItemRate { get; set; }
        public double? Vatpercent { get; set; }
        public double? FinalPrice { get; set; }
        public double? Quantity { get; set; }
        public double? Vatamount { get; set; }
    }
}
