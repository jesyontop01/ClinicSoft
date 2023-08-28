using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class InvTxnRequisitionForPo
    {
        public int RequisitionId { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
        public bool? IsPocreated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
