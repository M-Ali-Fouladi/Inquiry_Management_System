namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_MobileDevices
    {
        [Key]
        public Guid Guid { get; set; }

        public int UserID { get; set; }

        [StringLength(256)]
        public string DeviceName { get; set; }

        public int? OSType { get; set; }

        [StringLength(32)]
        public string DidgahVersion { get; set; }

        [StringLength(32)]
        public string OSVersion { get; set; }

        public bool? RemoteWipe { get; set; }

        public DateTime? FirstLoginDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public bool Deleted { get; set; }

        [Required]
        [StringLength(32)]
        public string DeviceID { get; set; }

        [MaxLength(256)]
        public byte[] AesKey { get; set; }

        [MaxLength(16)]
        public byte[] AesIV { get; set; }

        public string RegistrationID { get; set; }
    }
}
