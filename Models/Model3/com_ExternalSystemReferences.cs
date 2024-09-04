namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExternalSystemReferences
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid ExternalSystemGuid { get; set; }

        public Guid ParentGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public bool IsActive { get; set; }

        public Guid TargetEntityGuid { get; set; }

        public bool Deleted { get; set; }

        public bool IsCategory { get; set; }
    }
}
