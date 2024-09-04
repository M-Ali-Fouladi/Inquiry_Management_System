namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelLeaveMilestones_bk
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonnelBaseID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveTypeID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime CalculationDate { get; set; }

        public int? RemainingDays { get; set; }

        public int? RemainingXMins { get; set; }

        public int? RemainingYearlyDays { get; set; }

        public int? RemainingYearlyXMins { get; set; }

        public int? UsedDays { get; set; }

        public int? UsedMins { get; set; }
    }
}
