namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("____Configuration")]
    public partial class C____Configuration
    {
        [Key]
        [Column(Order = 0)]
        public Guid SoftwareGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Key { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(64)]
        public string ServerName { get; set; }

        public string Value { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(64)]
        public string InstanceName { get; set; }
    }
}
