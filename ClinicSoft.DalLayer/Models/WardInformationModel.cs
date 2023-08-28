using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class WardInformationModel
    {
        public string WardName { get; set; } = null!;
        public int TotalBeds { get; set; }
        public int Available { get; set; }
        public int Occupied { get; set; }
    }
}
