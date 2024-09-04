namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FailedExternalSystemNotifications
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid ExternalSystemGuid { get; set; }

        public Guid EntityGuid { get; set; }

        public Guid RecordGuid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public int ActionID { get; set; }
    }
}
