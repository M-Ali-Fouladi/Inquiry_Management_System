namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PredecreeValues
    {
        public int? PredecreeID_Back { get; set; }

        public int? ItemID_Back { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonnelBaseID { get; set; }

        public decimal? Amount { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PredecreeGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ItemGuid { get; set; }
    }
}
