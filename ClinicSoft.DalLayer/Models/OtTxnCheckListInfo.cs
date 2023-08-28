using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class OtTxnCheckListInfo
    {
        public int CheckListId { get; set; }
        public int OtbookingId { get; set; }
        public string? ChekListItemName { get; set; }
        public bool ItemValue { get; set; }
        public string? Itemdetails { get; set; }

        public virtual OtTxnBookingDetail Otbooking { get; set; } = null!;
    }
}
