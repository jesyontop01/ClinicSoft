using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class DanpheAudit
    {
        public long AuditId { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Data { get; set; } = null!;
    }
}
