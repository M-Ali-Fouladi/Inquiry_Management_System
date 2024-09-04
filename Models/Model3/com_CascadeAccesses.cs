namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_CascadeAccesses
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        public int AvailableUpperLevels { get; set; }

        public int AvailableLowerLevels { get; set; }

        public bool SameLevelAvailable { get; set; }

        public Guid? AssociationGuid { get; set; }

        public bool Active { get; set; }

        public Guid ModificationServerGuid { get; set; }

        public DateTime ModificationDate { get; set; }

        public bool Deleted { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
