namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemDefaults
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Back { get; set; }

        public int? ItemID_Back { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public decimal? DefaultValue { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid ItemGuid { get; set; }

        public int? PersonnelRelativeTable { get; set; }
    }
}
