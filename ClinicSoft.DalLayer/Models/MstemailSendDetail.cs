using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstemailSendDetail
    {
        public int SendId { get; set; }
        public int SendBy { get; set; }
        public string? SendToEmail { get; set; }
        public string? EmailSubject { get; set; }
        public DateTime? SendOn { get; set; }
    }
}
