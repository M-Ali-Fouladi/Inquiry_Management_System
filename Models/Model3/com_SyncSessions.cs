namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncSessions
    {
        public int ID { get; set; }

        public int? SyncType { get; set; }

        public DateTime? ExportDate { get; set; }

        public Guid? SyncGuid { get; set; }

        public Guid? ServerGuid { get; set; }

        public int? SyncSize { get; set; }

        public int? PackageCount { get; set; }

        public bool? TransferAck { get; set; }

        public bool? ImportAck { get; set; }

        public string TransferDescriptions { get; set; }

        public string ImportDescriptions { get; set; }

        public DateTime? TransferDate { get; set; }

        public DateTime? ImportDate { get; set; }

        public bool? ExportAck { get; set; }

        public string ExportDescriptions { get; set; }

        public Guid? SourceServerGuid { get; set; }

        public Guid? CurrentServerGuid { get; set; }
    }
}
