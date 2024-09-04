namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PromotionRequestSettings
    {
        [StringLength(512)]
        public string Value { get; set; }

        [Key]
        public Guid RequestGuid { get; set; }
    }
}
