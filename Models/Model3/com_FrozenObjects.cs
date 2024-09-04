namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FrozenObjects
    {
        public int Id { get; set; }

        public int? ObjectId { get; set; }

        public int? ObjectFlag { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(1024)]
        public string StateTitle { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "image")]
        public byte[] StateData { get; set; }

        public int OwnerFlag { get; set; }

        public int OwnerID { get; set; }

        public Guid? ObjectGuid { get; set; }
    }
}
