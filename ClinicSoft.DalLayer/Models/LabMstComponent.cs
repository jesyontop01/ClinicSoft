using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class LabMstComponent
    {
        public LabMstComponent()
        {
            LabLisComponentMaps = new HashSet<LabLisComponentMap>();
            LabMapTestComponents = new HashSet<LabMapTestComponent>();
        }

        public int ComponentId { get; set; }
        public string? ComponentName { get; set; }
        public string? Unit { get; set; }
        public string? ValueType { get; set; }
        public string? ControlType { get; set; }
        public string? Range { get; set; }
        public string? RangeDescription { get; set; }
        public string? Method { get; set; }
        public string? ValueLookup { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? DisplayName { get; set; }
        public string? MaleRange { get; set; }
        public string? FemaleRange { get; set; }
        public string? ChildRange { get; set; }

        public virtual ICollection<LabLisComponentMap> LabLisComponentMaps { get; set; }
        public virtual ICollection<LabMapTestComponent> LabMapTestComponents { get; set; }
    }
}
