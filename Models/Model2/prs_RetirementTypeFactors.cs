namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_RetirementTypeFactors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RetirementTypeID { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int? FactorType { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Percent { get; set; }

        public short? Responsible { get; set; }
    }
}
