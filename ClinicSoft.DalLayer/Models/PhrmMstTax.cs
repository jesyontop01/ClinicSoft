using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstTax
    {
        public int Taxid { get; set; }
        public string Taxname { get; set; } = null!;
        public double? Taxpercentage { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
    }
}
