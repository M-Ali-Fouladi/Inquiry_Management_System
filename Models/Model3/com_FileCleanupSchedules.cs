namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FileCleanupSchedules
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        [StringLength(1024)]
        public string ReferenceFlags { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModificationDateFrom { get; set; }

        public short? Status { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
