﻿using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPatientVisitNote
    {
        public int PatientVisitNoteId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int ProviderId { get; set; }
        public string? ChiefComplaint { get; set; }
        public string? HistoryOfPresentingIllness { get; set; }
        public string? ReviewOfSystems { get; set; }
        public string? Diagnosis { get; set; }
        public string? Heent { get; set; }
        public string? Chest { get; set; }
        public string? Cvs { get; set; }
        public string? Abdomen { get; set; }
        public string? Extremity { get; set; }
        public string? Skin { get; set; }
        public string? Neurological { get; set; }
        public string? LinesProse { get; set; }
        public DateTime? ProsDate { get; set; }
        public string? Site { get; set; }
        public string? ProsRemarks { get; set; }
        public string? FreeText { get; set; }
        public int? FollowUp { get; set; }
        public string? FollowUpUnit { get; set; }
        public string? Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
    }
}
