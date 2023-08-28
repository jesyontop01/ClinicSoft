using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstChartOfAccount
    {
        public int ChartOfAccountId { get; set; }
        public string? ChartOfAccountName { get; set; }
        public string? Coacode { get; set; }
        public int? PrimaryGroupId { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
