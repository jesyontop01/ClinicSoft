﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSoft.ServerModel
{
    public class LoginInformationModel
    {
        [Key]
        public int InformationId { get; set; }
        public int? EmployeeId { get; set; }
        public string UserName { get; set; }
        public string ActionName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
