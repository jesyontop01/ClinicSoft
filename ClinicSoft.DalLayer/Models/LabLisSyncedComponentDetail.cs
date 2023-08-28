using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabLisSyncedComponentDetail
    {
        public int LiscomponentResultId { get; set; }
        public bool SyncStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
