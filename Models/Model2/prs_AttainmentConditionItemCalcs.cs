namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_AttainmentConditionItemCalcs
    {
        public Guid? ItemGuid { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? ConditionCount { get; set; }

        public string ConditionText { get; set; }

        public string Condition { get; set; }

        public string Comment { get; set; }

        public bool? IsMandatory { get; set; }

        public bool? Active { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }
    }
}
