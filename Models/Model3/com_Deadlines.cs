namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Deadlines
    {
        public int ID { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? OwnerID { get; set; }

        public byte? OwnerFlag { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeadlineDate { get; set; }

        public string Message { get; set; }

        public bool? DismissOnView { get; set; }

        public bool? HasAlert { get; set; }

        [StringLength(1024)]
        public string Subject { get; set; }
    }
}
