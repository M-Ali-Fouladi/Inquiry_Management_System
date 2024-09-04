namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OrganizationRelatedPeople
    {
        public int Id { get; set; }

        public int? OrganizationID { get; set; }

        public int? DepartmentID { get; set; }

        public Guid? ParentGuid { get; set; }

        [StringLength(128)]
        public string Code { get; set; }

        public int? PersonTitleID { get; set; }

        [StringLength(2048)]
        public string Name { get; set; }

        [StringLength(2048)]
        public string Title { get; set; }

        [StringLength(1024)]
        public string DisplayTitle { get; set; }

        [StringLength(64)]
        public string AccountCode { get; set; }

        public bool Deleted { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(128)]
        public string Telephone { get; set; }

        public string Description { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        [StringLength(256)]
        public string Url { get; set; }

        [StringLength(16)]
        public string NationalCode { get; set; }

        public string GuidHierarchy { get; set; }

        [StringLength(32)]
        public string FaxNumber { get; set; }

        [StringLength(32)]
        public string CellPhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
