using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class AdtMstBabyBirthCondition
    {
        public AdtMstBabyBirthCondition()
        {
            AdtBabyBirthDetails = new HashSet<AdtBabyBirthDetail>();
        }

        public int BabyBirthConditionId { get; set; }
        public string BirthConditionType { get; set; } = null!;
        public int DischargeConditionId { get; set; }

        public virtual ICollection<AdtBabyBirthDetail> AdtBabyBirthDetails { get; set; }
    }
}
