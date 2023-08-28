using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnMstFrequency
    {
        public int FrequencyId { get; set; }
        public string Type { get; set; } = null!;
    }
}
