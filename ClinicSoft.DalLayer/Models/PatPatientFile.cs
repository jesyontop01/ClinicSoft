using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PatPatientFile
    {
        public long PatientFileId { get; set; }
        public int PatientId { get; set; }
        public Guid Rowguid { get; set; }
        public string? FileType { get; set; }
        public string? Description { get; set; }
        public string? FileName { get; set; }
        public int? FileNo { get; set; }
        public string? Title { get; set; }
        public string? FileExtention { get; set; }
        public DateTime? UploadedOn { get; set; }
        public int? UploadedBy { get; set; }
        public bool? IsActive { get; set; }
        public string? ImageFullPath { get; set; }
        public byte[]? FileBinaryData { get; set; }
    }
}
