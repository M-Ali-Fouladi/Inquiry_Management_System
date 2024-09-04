namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeItems
    {
        public int? DecreeID_Back { get; set; }

        public int? ItemID_Back { get; set; }

        public int? LadderDecreeID_Back { get; set; }

        public decimal? Amount { get; set; }

        public bool? Overridden { get; set; }

        public bool? Active { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DecreeGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ItemGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid LadderDecreeGuid { get; set; }
    }
}
