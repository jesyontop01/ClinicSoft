using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstLoinc
    {
        public int LoincId { get; set; }
        public string LoincCode { get; set; } = null!;
        public string? ShortName { get; set; }
        public string LongName { get; set; } = null!;
        public string? Component { get; set; }
    }
}
