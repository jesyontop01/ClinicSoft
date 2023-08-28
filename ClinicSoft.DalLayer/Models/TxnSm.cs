using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class TxnSm
    {
        public int SmsId { get; set; }
        public int? SmsCounter { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public string? SmsInformation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}
