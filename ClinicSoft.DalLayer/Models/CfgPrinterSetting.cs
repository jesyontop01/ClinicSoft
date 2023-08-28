using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CfgPrinterSetting
    {
        public int PrinterSettingId { get; set; }
        public string? PrintingType { get; set; }
        public string? GroupName { get; set; }
        public string? PrinterDisplayName { get; set; }
        public string? PrinterName { get; set; }
        public string? ModelName { get; set; }
        public int? WidthLines { get; set; }
        public int? HeightLines { get; set; }
        public int? HeaderGapLines { get; set; }
        public int? FooterGapLines { get; set; }
        public int? Mh { get; set; }
        public int? Ml { get; set; }
        public string? ServerFolderPath { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
