namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DigitalSignature
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; }

        public Guid? StaffGuid { get; set; }

        public int? ReferenceID { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public Guid UserCertificateGuid { get; set; }

        public Guid SignVersionGuid { get; set; }

        [Column(TypeName = "image")]
        public byte[] SignedContent { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? SignDate { get; set; }

        public bool Deleted { get; set; }
    }
}
