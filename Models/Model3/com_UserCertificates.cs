namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserCertificates
    {
        [Key]
        public Guid Guid { get; set; }

        public int UserID { get; set; }

        public int? Type { get; set; }

        public byte[] File { get; set; }

        [StringLength(65)]
        public string File_filename { get; set; }

        [StringLength(64)]
        public string SerialNumber { get; set; }

        public bool Active { get; set; }

        public DateTime Date { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }

        [StringLength(256)]
        public string Thumbprint { get; set; }

        public string SubjectDN { get; set; }
    }
}
