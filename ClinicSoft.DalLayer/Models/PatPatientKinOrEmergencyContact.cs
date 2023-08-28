using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientKinOrEmergencyContact
    {
        public int PatientKinOrEmergencyContactId { get; set; }
        public int PatientId { get; set; }
        public string? KinContactType { get; set; }
        public string? KinFirstName { get; set; }
        public string? KinLastName { get; set; }
        public string? KinPhoneNumber { get; set; }
        public string? KinComment { get; set; }
        public string? RelationShip { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
    }
}
