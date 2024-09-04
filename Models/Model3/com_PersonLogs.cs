namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonLogs
    {
        [Key]
        public Guid Guid { get; set; }

        public int? UserID { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? Event { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        public bool Deleted { get; set; }
    }
}
