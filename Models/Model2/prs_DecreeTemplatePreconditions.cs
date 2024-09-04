namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplatePreconditions
    {
        public int? DecreeTemplateID_Back { get; set; }

        public int? DecreeTemplateIDPreconditions_Back { get; set; }

        public int? GapTypeID { get; set; }

        public int? ObligationID { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DecreeTemplateGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DecreeTemplateGuidPreconditions { get; set; }
    }
}
