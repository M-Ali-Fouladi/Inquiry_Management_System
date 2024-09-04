namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_AuditEntityLogs
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid EntityGuid { get; set; }

        public DateTime EventDate { get; set; }

        public int EventType { get; set; }

        public int? UserID { get; set; }

        [Column(TypeName = "xml")]
        public string Data { get; set; }
    }
}
