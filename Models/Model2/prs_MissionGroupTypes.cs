namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionGroupTypes
    {
        [Key]
        [Column(Order = 0)]
        public Guid MissionGroupGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid MissionTypeGuid { get; set; }
    }
}
