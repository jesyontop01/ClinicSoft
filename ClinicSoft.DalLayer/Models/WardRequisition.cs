using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardRequisition
    {
        public int RequisitionId { get; set; }
        public int WardId { get; set; }
        public string? Status { get; set; }
        public string? ReferenceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? StoreId { get; set; }
    }
}
