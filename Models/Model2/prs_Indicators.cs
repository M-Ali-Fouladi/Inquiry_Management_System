namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Indicators
    {
        public int ID { get; set; }

        [StringLength(256)]
        public string Prefix { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(2048)]
        public string Comments { get; set; }

        public bool? Decreeable { get; set; }

        public bool? Missionable { get; set; }

        public bool? Deleted { get; set; }

        public bool? Leaveable { get; set; }

        public bool? PersonnelNoable { get; set; }

        [StringLength(512)]
        public string Pattern { get; set; }

        public bool? LeaveConfirmable { get; set; }

        public int? LastSequenceNo { get; set; }

        public bool? Promotionable { get; set; }

        public bool? Proclamationable { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
