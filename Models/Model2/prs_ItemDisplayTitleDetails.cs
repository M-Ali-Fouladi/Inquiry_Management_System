namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemDisplayTitleDetails
    {
        [Key]
        public Guid ItemDisplayTitleGuid { get; set; }

        public decimal? Value { get; set; }

        public string Title { get; set; }
    }
}
