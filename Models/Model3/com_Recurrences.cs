namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Recurrences
    {
        public int Id { get; set; }

        public byte? Type { get; set; }

        public int? Interval { get; set; }

        public int? RelativeInterval { get; set; }

        public int? RecurrenceFactor { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public byte? EndDateType { get; set; }

        public int? NoOfOccurrences { get; set; }

        public int? IndexOfLastOccurrence { get; set; }

        public int? OccurrenceLimit { get; set; }

        public int? StartTime { get; set; }

        public int? EndTime { get; set; }

        public int? Duration { get; set; }

        public short? DurationType { get; set; }

        [Column(TypeName = "text")]
        public string OccurrenceDates { get; set; }
    }
}
