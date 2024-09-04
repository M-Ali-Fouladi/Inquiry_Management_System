namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserPermissionGroups
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? UserGuid { get; set; }

        public Guid? PermissionGroupGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}
