namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Files
    {
        public int ID { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? FileTypeID { get; set; }

        [StringLength(256)]
        public string FileName { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public int? Size { get; set; }

        public string Comments { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int? FileNatureID { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public Guid? RepositoryGuid { get; set; }

        [MaxLength(32)]
        public byte[] Hash { get; set; }

        public int Age { get; set; }
    }
}
