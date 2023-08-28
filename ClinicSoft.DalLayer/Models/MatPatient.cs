using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MatPatient
    {
        public MatPatient()
        {
            MatFileUploads = new HashSet<MatFileUpload>();
            MatMaternityAncs = new HashSet<MatMaternityAnc>();
            MatRegisters = new HashSet<MatRegister>();
        }

        public int MaternityPatientId { get; set; }
        public int PatientId { get; set; }
        public string? HusbandName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime LastMenstrualPeriod { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string? PlaceOfDelivery { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? TypeOfDelivery { get; set; }
        public string? Obshistory { get; set; }
        public string? Presentation { get; set; }
        public string? Complications { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ConcludedBy { get; set; }
        public DateTime? ConcludedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsConcluded { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
        public virtual ICollection<MatFileUpload> MatFileUploads { get; set; }
        public virtual ICollection<MatMaternityAnc> MatMaternityAncs { get; set; }
        public virtual ICollection<MatRegister> MatRegisters { get; set; }
    }
}
