﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace ClinicSoft.ViewModel.Pharmacy
{
    public class RackViewModel
    {
        public int RackId { get; set; }
        public int? ParentId { get; set; }
        public string ParentRackName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int LocationId { get; set; }
    }
}
