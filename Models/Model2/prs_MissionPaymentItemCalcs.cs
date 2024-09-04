namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionPaymentItemCalcs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? ItemID { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public int? ConditionCount { get; set; }

        public int? FormulaCount { get; set; }

        public string ConditionText { get; set; }

        public string FormulaText { get; set; }

        public string Condition { get; set; }

        public string Formula { get; set; }

        public bool? Active { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? ItemGuid { get; set; }
    }
}
