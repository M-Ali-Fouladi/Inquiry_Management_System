namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PhysicalDatabases
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public Guid? OperationalServerGuid { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        [Required]
        [StringLength(128)]
        public string DataSource { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        [StringLength(64)]
        public string Password { get; set; }

        [StringLength(16)]
        public string Prefix { get; set; }

        public int? ConnectionTimeout { get; set; }

        public int? QueryTimeout { get; set; }

        public bool? Active { get; set; }

        public bool Deleted { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
