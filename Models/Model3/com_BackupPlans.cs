namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_BackupPlans
    {
        public int Id { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(2048)]
        public string BackupPath { get; set; }

        public byte? Flag { get; set; }

        public byte? WeekFrequency { get; set; }

        public byte? Weekdays { get; set; }

        [StringLength(5)]
        public string DayTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastBackup { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NextSchedule { get; set; }

        public int FailureCount { get; set; }

        public int FailureRetries { get; set; }

        public bool RetryFailedSchedule { get; set; }

        [Column(TypeName = "ntext")]
        public string LastError { get; set; }

        public bool Active { get; set; }

        public DateTime? LastFileArchiveBackupStart { get; set; }

        public int FileArchiveBackupMode { get; set; }
    }
}
