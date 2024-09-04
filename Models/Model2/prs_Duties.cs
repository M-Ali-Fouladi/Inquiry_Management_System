namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Duties
    {
        public int ID { get; set; }

        [Column("DutyGroupID-bak")]
        public int? DutyGroupID_bak { get; set; }

        public string Description { get; set; }

        public bool? Deleted { get; set; }

        public Guid? DutyGroupGuid { get; set; }
    }
}
