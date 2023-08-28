﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.ServerModel
{
    public class EthnicGroupModel
    {   
        [Key]
        public int EthnicGroupId { get; set; }
        public string EthnicGroup { get; set; }
        public string CastKeyWords { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
