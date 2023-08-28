using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class MstBank
    {
        public int BankId { get; set; }
        public string? BankShortName { get; set; }
        public string? BankName { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
