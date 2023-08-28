using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TblBillItemTemp
    {
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? ServiceDeptId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public string? ItemCode { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
    }
}
