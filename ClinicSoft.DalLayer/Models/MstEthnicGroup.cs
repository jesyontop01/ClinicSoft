using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstEthnicGroup
    {
        public int EthnicGroupId { get; set; }
        public string EthnicGroup { get; set; } = null!;
        public string? CastKeyWords { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
