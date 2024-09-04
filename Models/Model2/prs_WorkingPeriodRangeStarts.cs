namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkingPeriodRangeStarts
    {
        [Key]
        [Column(Order = 0)]
        public Guid WorkingPeriodGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid WorkingPeriodRangeGuid { get; set; }

        public int? TimekeeperStartingMonth { get; set; }

        public int? TimekeeperStartingDay { get; set; }

        public int? PayrollStartingMonth { get; set; }

        public int? PayrollStartingDay { get; set; }
    }
}
