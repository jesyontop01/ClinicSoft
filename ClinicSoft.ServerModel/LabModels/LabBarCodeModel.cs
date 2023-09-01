﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.ServerModel.LabModels
{
    public class LabBarCodeModel
    {
        [Key]
        public long BarCodeNumber { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarCodeId { get; set; }

        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }
    }

    public class BarCodeNumber
    {        
        public int Value { get; set; }
    }
   

}
