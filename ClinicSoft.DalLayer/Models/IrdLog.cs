using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class IrdLog
    {
        public int LogId { get; set; }
        public string? JsonData { get; set; }
        public string? Status { get; set; }
        public string? ResponseMessage { get; set; }
        public string? BillType { get; set; }
        public string? UrlInfo { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
