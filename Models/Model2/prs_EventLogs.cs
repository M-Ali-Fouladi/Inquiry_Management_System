namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EventLogs
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? UserGuid { get; set; }

        public Guid ReferenceGuid { get; set; }

        public int ReferenceID { get; set; }

        public int Event { get; set; }

        [StringLength(128)]
        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Time { get; set; }

        [StringLength(32)]
        public string IPAddress { get; set; }
    }
}
