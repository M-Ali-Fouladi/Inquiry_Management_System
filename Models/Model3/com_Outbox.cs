namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Outbox
    {
        [Key]
        public Guid Guid { get; set; }

        public int? Status { get; set; }

        public int? RetryCount { get; set; }

        public DateTime? FirstTryTime { get; set; }

        public DateTime? LastRetryTime { get; set; }

        public int? Type { get; set; }

        public int? TransportProtocol { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(64)]
        public string ReferenceIdentifier { get; set; }

        [StringLength(128)]
        public string MessageID { get; set; }

        public int? FailureSource { get; set; }

        public string FailureReason { get; set; }

        [StringLength(64)]
        public string ReceiverIdentifier { get; set; }

        [StringLength(1024)]
        public string SenderInfo { get; set; }

        [StringLength(1024)]
        public string ReceiverInfo { get; set; }

        public string ExtraInfo { get; set; }

        public DateTime? ExpireDate { get; set; }

        public int Priority { get; set; }

        public string TransportData { get; set; }

        public DateTime ScheduledTime { get; set; }
    }
}
