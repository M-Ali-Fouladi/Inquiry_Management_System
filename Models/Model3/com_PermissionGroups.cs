namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PermissionGroups
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(512)]
        public string Title { get; set; }

        public string Description { get; set; }

        public Guid AccessZoneGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? Active { get; set; }

        public bool Deleted { get; set; }

        public int PermissionGroupType { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
