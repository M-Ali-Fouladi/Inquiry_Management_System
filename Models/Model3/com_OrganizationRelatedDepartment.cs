namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OrganizationRelatedDepartment
    {
        public int ID { get; set; }

        public int? OrganizationID { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public Guid? ParentGuid { get; set; }

        public bool Deleted { get; set; }

        public Guid? Guid { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(128)]
        public string Telephone { get; set; }

        public string Description { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public Guid? DepartmentGuid { get; set; }

        [StringLength(256)]
        public string LinkServerEmail { get; set; }

        [StringLength(256)]
        public string LinkServerUrl { get; set; }

        public int? LinkType { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        [StringLength(1024)]
        public string GuidHierarchy { get; set; }

        [StringLength(256)]
        public string SapadPartyID { get; set; }
    }
}
