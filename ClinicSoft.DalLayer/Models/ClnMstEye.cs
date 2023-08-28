using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnMstEye
    {
        public int Id { get; set; }
        public int? VisitId { get; set; }
        public int? ProviderId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? VisitDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
