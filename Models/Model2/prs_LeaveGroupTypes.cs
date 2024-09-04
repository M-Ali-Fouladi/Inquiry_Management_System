namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveGroupTypes
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveGroupID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveTypeID { get; set; }

        public int? OrderIndex { get; set; }

        public bool? RelatedPriority { get; set; }

        public int? PriorityIndex { get; set; }

        public bool? MeritDefault { get; set; }

        public bool? HideFromUser { get; set; }
    }
}
