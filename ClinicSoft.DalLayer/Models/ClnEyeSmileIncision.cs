using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class ClnEyeSmileIncision
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public int? Position { get; set; }
        public int? Width { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsOd { get; set; }
    }
}
