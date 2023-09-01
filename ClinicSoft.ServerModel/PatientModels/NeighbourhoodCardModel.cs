﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.ServerModel
{
    public class NeighbourhoodCardModel
    {
        [Key]
        public int NeighbourhoodCardId { get; set; }
        public int PatientId { get; set; }
        public string? LPNo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
