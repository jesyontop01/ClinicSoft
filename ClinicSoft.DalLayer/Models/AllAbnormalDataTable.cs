using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AllAbnormalDataTable
    {
        public string? Range { get; set; }
        public long TestComponentResultId { get; set; }
        public string? Value { get; set; }
    }
}
