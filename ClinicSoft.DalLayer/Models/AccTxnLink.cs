using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccTxnLink
    {
        public int AccountingTxnLinkId { get; set; }
        public int? TransactionId { get; set; }
        public string? ReferenceId { get; set; }
        public string? ReferenceIdOne { get; set; }

        public virtual AccTransaction? Transaction { get; set; }
    }
}
