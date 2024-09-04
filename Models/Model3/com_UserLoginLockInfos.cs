namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserLoginLockInfos
    {
        public int ID { get; set; }

        public Guid UserGuid { get; set; }

        public int? LoginFailedCount { get; set; }

        public int LockType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastLockDate { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }
    }
}
