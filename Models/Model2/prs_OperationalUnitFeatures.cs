namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_OperationalUnitFeatures
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationalUnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SoftwareGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FeatureFlag { get; set; }

        public int? FeatureID { get; set; }

        public Guid? FeatureGuid { get; set; }
    }
}
