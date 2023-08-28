using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BilCfgBillItemPrice
    {
        public BilCfgBillItemPrice()
        {
            FrcPercentSettings = new HashSet<FrcPercentSetting>();
            InctvBillItemsProfileMaps = new HashSet<InctvBillItemsProfileMap>();
            InctvMapEmployeeBillItemsMaps = new HashSet<InctvMapEmployeeBillItemsMap>();
        }

        public int BillItemPriceId { get; set; }
        public int? ServiceDepartmentId { get; set; }
        public string? ItemName { get; set; }
        public double? Price { get; set; }
        public int? ItemId { get; set; }
        public bool? TaxApplicable { get; set; }
        public bool? DiscountApplicable { get; set; }
        public string? Description { get; set; }
        public string? ProcedureCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public int? DisplaySeq { get; set; }
        public string? ItemCode { get; set; }
        public bool? IsDoctorMandatory { get; set; }
        public string? IntegrationName { get; set; }
        public bool? HasAdditionalBillingItems { get; set; }
        public double? Ehsprice { get; set; }
        public double? SaarccitizenPrice { get; set; }
        public double? ForeignerPrice { get; set; }
        public double? GovtInsurancePrice { get; set; }
        public bool IsFractionApplicable { get; set; }
        public bool InsuranceApplicable { get; set; }
        public bool IsInsurancePackage { get; set; }
        public bool? IsNormalPriceApplicable { get; set; }
        public bool? IsEhspriceApplicable { get; set; }
        public bool? IsForeignerPriceApplicable { get; set; }
        public bool? IsSaarcpriceApplicable { get; set; }
        public bool? IsOt { get; set; }
        public bool? IsProc { get; set; }
        public string? Category { get; set; }
        public bool? AllowMultipleQty { get; set; }
        public double? InsForeignerPrice { get; set; }
        public bool? IsInsForeignerPriceApplicable { get; set; }
        public string? DefaultDoctorList { get; set; }
        public bool? IsValidForReporting { get; set; }
        public bool? IsZeroPriceAllowed { get; set; }
        public bool? IsErLabApplicable { get; set; }

        public virtual BilMstServiceDepartment? ServiceDepartment { get; set; }
        public virtual ICollection<FrcPercentSetting> FrcPercentSettings { get; set; }
        public virtual ICollection<InctvBillItemsProfileMap> InctvBillItemsProfileMaps { get; set; }
        public virtual ICollection<InctvMapEmployeeBillItemsMap> InctvMapEmployeeBillItemsMaps { get; set; }
    }
}
