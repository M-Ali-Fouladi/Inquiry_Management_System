namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserLogins
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [StringLength(32)]
        public string SessionID { get; set; }

        [StringLength(32)]
        public string IPAddress { get; set; }

        [StringLength(64)]
        public string ComputerName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LoginTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LogoutTime { get; set; }

        public bool? AutoLogout { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastActivityTime { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }
    }
}
