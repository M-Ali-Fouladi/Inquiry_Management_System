namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_PostCostCenters-old")]
    public partial class prs_PostCostCenters_old
    {
        public int? CostCenterID_Back { get; set; }

        public bool? Active { get; set; }

        public Guid? CostCenterGuid { get; set; }

        public int ID { get; set; }

        public Guid? PostGuid { get; set; }
    }
}
