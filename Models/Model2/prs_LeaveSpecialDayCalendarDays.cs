namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveSpecialDayCalendarDays
    {
        [Key]
        [Column(Order = 0)]
        public Guid LeaveSpecialDayCalendarGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Month { get; set; }

        [StringLength(128)]
        public string Days { get; set; }
    }
}
