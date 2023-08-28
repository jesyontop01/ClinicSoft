using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreLookupDetail
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public int? DisplaySequence { get; set; }
        public int? ParentId { get; set; }
        public bool? IsActive { get; set; }
    }
}
