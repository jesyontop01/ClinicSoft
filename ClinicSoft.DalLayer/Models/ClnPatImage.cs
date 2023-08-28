using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnPatImage
    {
        public long PatImageId { get; set; }
        public int PatientId { get; set; }
        public int PatientVisitId { get; set; }
        public int? DepartmentId { get; set; }
        public Guid Rowguid { get; set; }
        public string? FileType { get; set; }
        public string? Comment { get; set; }
        public string? FileName { get; set; }
        public string? Title { get; set; }
        public string? FileExtention { get; set; }
        public DateTime? UploadedOn { get; set; }
        public int? UploadedBy { get; set; }
        public bool? IsActive { get; set; }
        public byte[]? FileBinaryData { get; set; }
    }
}
