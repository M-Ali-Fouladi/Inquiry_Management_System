namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SoftwareSettings
    {
        [Key]
        [Column(Order = 0)]
        public Guid SoftwareGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Key { get; set; }

        [StringLength(1024)]
        public string Value { get; set; }
    }
}
