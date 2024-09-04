namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DeprivationGroups
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public int? Percent { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }
    }
}
