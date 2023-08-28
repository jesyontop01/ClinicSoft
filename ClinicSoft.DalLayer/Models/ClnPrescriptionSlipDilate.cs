using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPrescriptionSlipDilate
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public bool? Atropine { get; set; }
        public bool? Cp { get; set; }
        public bool? Ctc { get; set; }
        public bool? Tplus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
