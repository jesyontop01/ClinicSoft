using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMstStockBarcode
    {
        public PhrmMstStockBarcode()
        {
            PhrmMstStocks = new HashSet<PhrmMstStock>();
        }

        public int BarcodeId { get; set; }
        public int ItemId { get; set; }
        public string? BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal Mrp { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PhrmMstItem Item { get; set; } = null!;
        public virtual ICollection<PhrmMstStock> PhrmMstStocks { get; set; }
    }
}
