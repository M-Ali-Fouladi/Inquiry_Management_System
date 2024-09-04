namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserSessionPolicies
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; }

        public short? AllowedSessionsCount { get; set; }

        public short? FailureBehavior { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? Banned { get; set; }
    }
}
