namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Reports
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public Guid EntityGuid { get; set; }

        public Guid GroupGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        public string Query { get; set; }

        public bool Deleted { get; set; }

        public Guid? CategoryGuid { get; set; }
    }
}
