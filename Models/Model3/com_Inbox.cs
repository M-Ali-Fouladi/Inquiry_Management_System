namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Inbox
    {
        [Key]
        public Guid Guid { get; set; }

        public string SenderInfo { get; set; }

        public string ReceiverInfo { get; set; }

        public int? Status { get; set; }

        public int? RetryCount { get; set; }

        public DateTime? FirstTryTime { get; set; }

        public DateTime? LastRetryTime { get; set; }

        public int? Type { get; set; }

        public int? TransportProtocol { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? FailureSource { get; set; }

        public string FailureReason { get; set; }

        public DateTime? RegisterationDate { get; set; }

        public string MessageInfo { get; set; }
    }
}
