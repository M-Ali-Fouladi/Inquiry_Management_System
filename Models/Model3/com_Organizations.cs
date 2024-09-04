namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Organizations
    {
        public int Id { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? ContactId { get; set; }

        [StringLength(64)]
        public string AccountCode { get; set; }

        public Guid? LinkServerCode { get; set; }

        public bool Deleted { get; set; }

        public bool? Unorganized { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(128)]
        public string Telephone { get; set; }

        public string Description { get; set; }

        [StringLength(128)]
        public string LinkServerEmail { get; set; }

        [StringLength(1024)]
        public string LinkServerUrl { get; set; }

        public Guid? OrganizationGuid { get; set; }

        public int? LinkType { get; set; }

        public bool? ShamimOrganization { get; set; }

        public int? OrderIndex { get; set; }

        public int? BodyFileReceivingType { get; set; }

        public int? BodyFileImageReceivingType { get; set; }

        [StringLength(32)]
        public string OrganizationCode { get; set; }

        public int? OrganizationNature { get; set; }

        public Guid? RelatedOrganizationTypeGuid { get; set; }

        public int? ReceiverServerType { get; set; }

        [StringLength(256)]
        public string SapadPartyID { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
