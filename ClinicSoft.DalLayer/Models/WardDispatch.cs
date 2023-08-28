using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardDispatch
    {
        public int DispatchId { get; set; }
        public int? RequisitionId { get; set; }
        public decimal SubTotal { get; set; }
        public string? Remark { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? ReceivedBy { get; set; }
        public int? StoreId { get; set; }
    }
}
