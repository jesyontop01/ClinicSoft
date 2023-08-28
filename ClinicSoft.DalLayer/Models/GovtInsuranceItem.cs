using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class GovtInsuranceItem
    {
        public int? Sno { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public string? ServiceDepartmentName { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public int? ImagingTypeId { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public bool? IsPackage { get; set; }
        public string? IntegrationName { get; set; }
    }
}
