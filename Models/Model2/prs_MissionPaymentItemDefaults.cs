namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionPaymentItemDefaults
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? ItemID { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DefaultValue { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? ItemGuid { get; set; }
    }
}
