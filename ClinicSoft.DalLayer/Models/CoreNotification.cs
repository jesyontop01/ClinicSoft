using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreNotification
    {
        public int NotificationId { get; set; }
        public string NotificationModuleName { get; set; } = null!;
        public string NotificationTitle { get; set; } = null!;
        public string? NotificationDetails { get; set; }
        public int? RecipientId { get; set; }
        public string? ParentTableName { get; set; }
        public int? NotificationParentId { get; set; }
        public bool? IsRead { get; set; }
        public int? ReadBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsArchived { get; set; }
        public string? RecipientType { get; set; }
        public string? SubModuleName { get; set; }
    }
}
