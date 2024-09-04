namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_UnitCostCenters
    {
        [Key]
        [Column(Order = 0)]
        public Guid CostCenterGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        public Guid? UnitGuid { get; set; }
    }
}
