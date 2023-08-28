using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstPrimaryGroup
    {
        public int PrimaryGroupId { get; set; }
        public string? PrimaryGroupCode { get; set; }
        public string? PrimaryGroupName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
