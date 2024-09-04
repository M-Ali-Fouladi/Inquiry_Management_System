namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateItemTemplateItems
    {
        public int? DecreeTemplateItemTemplateID_Back { get; set; }

        public int? ItemID_Back { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DecreeTemplateItemTemplateGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ItemGuid { get; set; }
    }
}
