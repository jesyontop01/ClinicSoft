using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class Oppatient
    {
        public int OppatientId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Age { get; set; }
        public string? Gender { get; set; }
        public string? VillageCity { get; set; }
        public string? Taluka { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsEmrpatient { get; set; }
    }
}
