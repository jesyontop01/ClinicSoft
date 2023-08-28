using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class PhrmMapGenericDosaseNfreq
    {
        public int GenericDosageMapId { get; set; }
        public int? GenericId { get; set; }
        public string? GenericName { get; set; }
        public string? Dosage { get; set; }
        public string? Route { get; set; }
        public double? Frequency { get; set; }
        public string? FreqInWords { get; set; }
    }
}
