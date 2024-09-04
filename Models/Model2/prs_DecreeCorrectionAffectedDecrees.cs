namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeCorrectionAffectedDecrees
    {
        public int? DecreeID_Back { get; set; }

        public int? AffectedDecreeID_Back { get; set; }

        public int? AffectionJobGroupCode { get; set; }

        public bool? Active { get; set; }

        public int? AffectionJobBaseCode { get; set; }

        [StringLength(256)]
        public string AffectionJobGradeTitle { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid DecreeGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AffectedDecreeGuid { get; set; }

        public DateTime? RegistrarDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AffectedDecreeEffectiveDate { get; set; }

        [StringLength(128)]
        public string AffectionExpertGradeTitle { get; set; }
    }
}
