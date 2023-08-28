using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class UpdatedBillItemPriceTable
    {
        public int BillitemId { get; set; }
        public string? Department { get; set; }
        public string? Itemname { get; set; }
        public double? Price { get; set; }
    }
}
