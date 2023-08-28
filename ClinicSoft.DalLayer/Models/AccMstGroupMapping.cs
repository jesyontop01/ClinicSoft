using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstGroupMapping
    {
        public AccMstGroupMapping()
        {
            AccMstMappingDetails = new HashSet<AccMstMappingDetail>();
        }

        public int GroupMappingId { get; set; }
        public string? Description { get; set; }
        public int? Section { get; set; }
        public string? Details { get; set; }
        public int? VoucherId { get; set; }
        public string? Remarks { get; set; }
        public int? CustomVoucherId { get; set; }

        public virtual ICollection<AccMstMappingDetail> AccMstMappingDetails { get; set; }
    }
}
