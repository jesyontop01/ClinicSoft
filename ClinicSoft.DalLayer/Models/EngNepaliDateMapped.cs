using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class EngNepaliDateMapped
    {
        public int DateMapNum { get; set; }
        public int? EngYear { get; set; }
        public int? NepYear { get; set; }
        public int? EngMonth { get; set; }
        public int? NepMonth { get; set; }
        public int? EngDay { get; set; }
        public int? NepDay { get; set; }
    }
}
