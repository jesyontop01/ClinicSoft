using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TxnPrintInformation
    {
        public int PrintId { get; set; }
        public string? ModuleName { get; set; }
        public string? DocumentName { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? PrintedOn { get; set; }
        public int? PrintedBy { get; set; }
        public int? PrintCount { get; set; }
    }
}
