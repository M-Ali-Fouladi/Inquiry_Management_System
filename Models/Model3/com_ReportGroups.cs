namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReportGroups
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid EntityGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public string Comments { get; set; }

        public Guid? ApplicationGuid { get; set; }
    }
}
