using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstGovFreeServiceCategory
    {
        public int FreeServiceId { get; set; }
        public string? FreeServiceName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
