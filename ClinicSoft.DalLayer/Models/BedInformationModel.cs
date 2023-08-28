using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class BedInformationModel
    {
        public int BedNumber { get; set; }
        public decimal Price { get; set; }
        public string? BedTypeName { get; set; }
        public bool IsOccupied { get; set; }
        public string? WardName { get; set; }
    }
}
