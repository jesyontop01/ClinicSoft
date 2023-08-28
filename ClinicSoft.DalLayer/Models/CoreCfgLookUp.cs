using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreCfgLookUp
    {
        public int LookUpId { get; set; }
        public string ModuleName { get; set; } = null!;
        public string LookUpName { get; set; } = null!;
        public string? LookupDataJson { get; set; }
        public string? Description { get; set; }
    }
}
