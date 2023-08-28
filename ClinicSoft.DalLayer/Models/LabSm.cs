using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabSm
    {
        public int SmsId { get; set; }
        public string? Message { get; set; }
        public int? RequisitionId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
