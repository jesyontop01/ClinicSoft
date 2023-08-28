using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccBillLedgerMapping
    {
        public int BillLedgerMappingId { get; set; }
        public int LedgerId { get; set; }
        public int ServiceDepartmentId { get; set; }
        public int? ItemId { get; set; }
        public int? HospitalId { get; set; }
    }
}
