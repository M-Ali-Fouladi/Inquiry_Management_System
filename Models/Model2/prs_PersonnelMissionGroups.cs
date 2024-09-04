namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelMissionGroups
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid MissionGroupGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }

        public int PersonnelBaseID { get; set; }

        public bool? Deleted { get; set; }
    }
}
