using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class NewItemHam
    {
        public int? ItemIdNew { get; set; }
        public int? SN { get; set; }
        public string? DepartmentName { get; set; }
        public int? ServiceDeptId { get; set; }
        public string? ServDept { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public double? NewPrice { get; set; }
    }
}
