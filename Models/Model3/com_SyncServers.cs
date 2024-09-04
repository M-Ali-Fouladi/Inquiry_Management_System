namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncServers
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public bool? Master { get; set; }

        public bool? Me { get; set; }

        [StringLength(1024)]
        public string Email { get; set; }

        public bool Deleted { get; set; }

        public Guid? Guid { get; set; }

        [StringLength(2048)]
        public string Url { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? LastExportDate { get; set; }

        public DateTime? LastImportDate { get; set; }

        public int? DelayWarningInterval { get; set; }

        public int? MaximumUserCount { get; set; }

        [StringLength(128)]
        public string Version { get; set; }

        public int? DelayDocumentManagerInterval { get; set; }

        public string NetworkLayout { get; set; }

        [StringLength(256)]
        public string SecretKey { get; set; }
    }
}
