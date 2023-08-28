using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AccMstCodeDetail
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? HospitalId { get; set; }
    }
}
