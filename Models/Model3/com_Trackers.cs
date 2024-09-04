namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Trackers
    {
        public int ID { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableKey { get; set; }

        public int? RecordID { get; set; }

        public bool? Active { get; set; }

        public int? StatusID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StatusDate { get; set; }

        public int? UserID { get; set; }
    }
}
