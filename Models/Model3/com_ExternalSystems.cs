namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExternalSystems
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [Required]
        [StringLength(512)]
        public string WebServiceUrl { get; set; }

        [MaxLength(256)]
        public byte[] AesKey { get; set; }

        [MaxLength(16)]
        public byte[] AesIV { get; set; }

        public bool Deleted { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        public byte[] Password { get; set; }

        [StringLength(1024)]
        public string ValidIPs { get; set; }
    }
}
