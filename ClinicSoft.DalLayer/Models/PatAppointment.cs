using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatAppointment
    {
        public int AppointmentId { get; set; }
        public int? PatientId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Gender { get; set; }
        public string? ContactNumber { get; set; }
        public string? ProviderName { get; set; }
        public string AppointmentType { get; set; } = null!;
        public DateTime? AppointmentDate { get; set; }
        public TimeSpan? AppointmentTime { get; set; }
        public int? ProviderId { get; set; }
        public string? AppointmentStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string? Reason { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public string? CancelledRemarks { get; set; }
        public int? DepartmentId { get; set; }
        public string? MiddleName { get; set; }
        public string? Age { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual EmpEmployee? CreatedByNavigation { get; set; }
        public virtual PatPatient? Patient { get; set; }
    }
}
