namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveDecreasingDays
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LeaveID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int? RawLengthMinutes { get; set; }

        public int? LengthMinutes { get; set; }

        public int? DayWorkMinutes { get; set; }

        public int? DayType { get; set; }
    }
}
