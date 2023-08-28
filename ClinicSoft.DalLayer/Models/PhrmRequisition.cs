using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmRequisition
    {
        public PhrmRequisition()
        {
            PhrmRequisitionItems = new HashSet<PhrmRequisitionItem>();
        }

        public int RequisitionId { get; set; }
        public int VisitId { get; set; }
        public int PatientId { get; set; }
        public string? Status { get; set; }
        /// <summary>
        /// Comman seperated id of table PHRM_SaleItems
        /// </summary>
        public string? ReferenceId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PatPatient Patient { get; set; } = null!;
        public virtual ICollection<PhrmRequisitionItem> PhrmRequisitionItems { get; set; }
    }
}
