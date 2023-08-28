using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TempLabNewPrice
    {
        public int? NewItemId { get; set; }
        public string? Department { get; set; }
        public string? SrvDeptName { get; set; }
        public string? ItemName { get; set; }
        public double? NewRate { get; set; }
        public bool? IsFoundInOld { get; set; }
        public bool? IsPriceDifferent { get; set; }
        public double? OldRate { get; set; }
        public int? SrvDeptId { get; set; }
        public int? ItemId { get; set; }
    }
}
