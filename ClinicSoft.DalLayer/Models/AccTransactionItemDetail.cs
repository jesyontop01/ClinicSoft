using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTransactionItemDetail
    {
        public int TransactionItemDetailId { get; set; }
        public int? TransactionItemId { get; set; }
        public double? Amount { get; set; }
        public string? Description { get; set; }
        public int? ReferenceId { get; set; }
        public string? ReferenceType { get; set; }
    }
}
