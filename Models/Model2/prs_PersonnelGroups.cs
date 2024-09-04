namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelGroups
    {
        public int? OrderIndex { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int? OwnerID { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public int? OperationalUnitID { get; set; }

        public bool? Active { get; set; }

        public bool Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public bool? ShareForAll { get; set; }
    }
}
