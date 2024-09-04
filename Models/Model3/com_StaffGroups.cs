namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StaffGroups
    {
        public int Id { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? OwnerId { get; set; }

        public bool? HotListFlag { get; set; }

        public int? Flag { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }

        public int? AccessZoneID { get; set; }
    }
}
