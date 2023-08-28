using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabLabTestsWithCorrectedCategory
    {
        public int LabTestWithCategoryId { get; set; }
        public string? LabTestName { get; set; }
        public string? Category { get; set; }
        public string? CorrectedCategory { get; set; }
        public int? CategoryId { get; set; }
    }
}
