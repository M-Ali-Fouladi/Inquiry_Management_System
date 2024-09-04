namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_JobGroups
    {
        [Key]
        [Column(Order = 0, TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BaseSalary { get; set; }
    }
}
