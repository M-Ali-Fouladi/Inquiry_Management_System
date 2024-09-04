namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncServersInfo
    {
        [Key]
        [Column(Order = 0)]
        public Guid ServerGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TargetGuid { get; set; }

        [StringLength(1024)]
        public string Url { get; set; }

        public int? Status { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? EmailAlertSendDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastAlertGenerateDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SourceServerGuid { get; set; }

        public byte? MaxConnectionCount { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SmsAlertSendDate { get; set; }
    }
}
