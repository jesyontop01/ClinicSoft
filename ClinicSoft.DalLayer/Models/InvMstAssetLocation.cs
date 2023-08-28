using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvMstAssetLocation
    {
        public int LocationId { get; set; }
        public string? LocationName { get; set; }
        public string? LocationDetails { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
