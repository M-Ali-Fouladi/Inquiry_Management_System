namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Predecrees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Back { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EffectiveDate { get; set; }

        [StringLength(2048)]
        public string Title { get; set; }

        public bool? Completed { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }
    }
}
