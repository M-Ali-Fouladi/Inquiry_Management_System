namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OrganizationRelatedPeopleGroups
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public int? OwnerID { get; set; }

        public int? Flag { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }

        public Guid? Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public int? AccessZoneID { get; set; }
    }
}
