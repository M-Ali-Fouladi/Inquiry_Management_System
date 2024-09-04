namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StaffPermissionGroupAccessCodes
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? GroupGuid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? ObjectType { get; set; }

        public int? ObjectID { get; set; }

        public Guid? ObjectGuid { get; set; }

        public int? AccessCode { get; set; }

        public bool? Denied { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }

        public Guid? CategoryGuid { get; set; }
    }
}
