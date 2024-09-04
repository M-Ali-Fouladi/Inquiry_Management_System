namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_RelatedOrganizationTypes
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public short? OrderIndex { get; set; }

        public Guid? AccessZoneGuid { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
