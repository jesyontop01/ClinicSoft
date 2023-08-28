using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class OtTxnOtTeamsInfo
    {
        public int OtteamId { get; set; }
        public int EmployeeId { get; set; }
        public int OtbookingId { get; set; }
        public int PatientId { get; set; }
        public int? PatientVisitId { get; set; }
        public string? RoleType { get; set; }

        public virtual EmpEmployee Employee { get; set; } = null!;
        public virtual OtTxnBookingDetail Otbooking { get; set; } = null!;
        public virtual PatPatient Patient { get; set; } = null!;
        public virtual PatPatientVisit? PatientVisit { get; set; }
    }
}
