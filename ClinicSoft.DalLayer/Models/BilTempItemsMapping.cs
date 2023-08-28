using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilTempItemsMapping
    {
        public int? ServiceDepartmentId { get; set; }
        public string? ItemName { get; set; }
        public int? OldItemId { get; set; }
        public int? NewItemId { get; set; }
    }
}
