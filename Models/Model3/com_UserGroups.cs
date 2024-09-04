namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserGroups
    {
        [StringLength(1024)]
        public string Title { get; set; }

        public int? OwnerId { get; set; }

        public int? AccessZoneID { get; set; }

        public int? OrderIndex { get; set; }

        public int? Flag { get; set; }

        public bool Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(64)]
        public string AccessType { get; set; }
    }
}
