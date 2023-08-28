using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatNeighbourhoodCardDetail
    {
        public int NeighbourhoodCardId { get; set; }
        public int PatientId { get; set; }
        public string? PatientCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
