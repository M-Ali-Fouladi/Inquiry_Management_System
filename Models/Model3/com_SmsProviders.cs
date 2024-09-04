namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SmsProviders
    {
        public int ID { get; set; }

        public Guid Guid { get; set; }

        [Required]
        [StringLength(256)]
        public string DisplayName { get; set; }

        public int? SmsProviderType { get; set; }

        [Required]
        [StringLength(256)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Domain { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [StringLength(1024)]
        public string Password { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }
    }
}
