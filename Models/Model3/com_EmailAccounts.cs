namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EmailAccounts
    {
        public int ID { get; set; }

        public Guid Guid { get; set; }

        public Guid? OwnerGuid { get; set; }

        public int? OwnerFlag { get; set; }

        [StringLength(512)]
        public string DisplayName { get; set; }

        [StringLength(256)]
        public string FullName { get; set; }

        [StringLength(256)]
        public string EmailAddress { get; set; }

        [StringLength(256)]
        public string ReplyAddress { get; set; }

        [StringLength(256)]
        public string Pop3Server { get; set; }

        public int Pop3Port { get; set; }

        [StringLength(256)]
        public string Pop3AccountName { get; set; }

        [StringLength(2048)]
        public string Pop3Password { get; set; }

        public bool? Pop3DeleteFromServer { get; set; }

        [StringLength(256)]
        public string SmtpServer { get; set; }

        public int SmtpPort { get; set; }

        [StringLength(256)]
        public string SmtpAccountName { get; set; }

        [StringLength(1024)]
        public string SmtpPassword { get; set; }

        public int SmtpMaxSendPerMinute { get; set; }

        public int BounceCount { get; set; }

        public DateTime? LastResponseTime { get; set; }

        public string LastResponse { get; set; }

        public bool AutoSynchronize { get; set; }

        public bool? RequireSecurePasswordAuthentication { get; set; }

        public int? IncomingServerEncryptedConnectionType { get; set; }

        public int? OutgoingServerEncryptedConnectionType { get; set; }

        public int? MailServerType { get; set; }

        public DateTime ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public bool? Deleted { get; set; }
    }
}
