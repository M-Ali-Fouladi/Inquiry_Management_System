namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkHistorySettings
    {
        [Key]
        public Guid Guid { get; set; }

        public int? EnumTitle { get; set; }

        [StringLength(128)]
        public string DisplayTitle { get; set; }

        public bool? Active { get; set; }

        public decimal? Coefficient { get; set; }

        public bool? ViewSum { get; set; }

        public Guid? TenantGuid { get; set; }

        public bool? EffectiveInPersonnelHistorySum { get; set; }

        public bool? EffectiveInDecreeCalculationItem { get; set; }
    }
}
