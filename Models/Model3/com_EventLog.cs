namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EventLog
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? Event { get; set; }

        [StringLength(32)]
        public string SessionID { get; set; }

        [StringLength(40)]
        public string IPAddress { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        [StringLength(128)]
        public string Comments { get; set; }

        public int? ReferenceID { get; set; }

        public Guid? ReferenceGuid { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }
    }
}
