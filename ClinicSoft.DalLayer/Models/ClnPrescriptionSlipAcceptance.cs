using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPrescriptionSlipAcceptance
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string? SphOd { get; set; }
        public string? SphOs { get; set; }
        public string? CylOd { get; set; }
        public string? CylOs { get; set; }
        public string? VaOs { get; set; }
        public string? VaOd { get; set; }
        public string? AxisOd { get; set; }
        public string? AxisOs { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
