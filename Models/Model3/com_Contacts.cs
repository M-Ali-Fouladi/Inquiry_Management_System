namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Contacts
    {
        public int Id { get; set; }

        public int? OwnerId { get; set; }

        public int? OwnerFlag { get; set; }

        [StringLength(1024)]
        public string FullName { get; set; }

        [StringLength(512)]
        public string DisplayName { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(512)]
        public string Company { get; set; }

        [StringLength(256)]
        public string WebPageURL { get; set; }

        [StringLength(128)]
        public string Email1 { get; set; }

        [StringLength(128)]
        public string Email2 { get; set; }

        [StringLength(128)]
        public string Email3 { get; set; }

        [StringLength(128)]
        public string HomePhone1 { get; set; }

        [StringLength(128)]
        public string HomePhone2 { get; set; }

        [StringLength(128)]
        public string HomePhone3 { get; set; }

        [StringLength(128)]
        public string BusinessPhone1 { get; set; }

        [StringLength(128)]
        public string BusinessPhone2 { get; set; }

        [StringLength(128)]
        public string BusinessPhone3 { get; set; }

        [StringLength(128)]
        public string CompanyPhone1 { get; set; }

        [StringLength(128)]
        public string CompanyPhone2 { get; set; }

        [StringLength(128)]
        public string CompanyPhone3 { get; set; }

        [StringLength(128)]
        public string MobilePhone1 { get; set; }

        [StringLength(128)]
        public string MobilePhone2 { get; set; }

        [StringLength(128)]
        public string MobilePhone3 { get; set; }

        [StringLength(128)]
        public string Fax1 { get; set; }

        [StringLength(128)]
        public string Fax2 { get; set; }

        [StringLength(128)]
        public string Fax3 { get; set; }

        [StringLength(2048)]
        public string HomeAddress { get; set; }

        [StringLength(2048)]
        public string OfficeAddress { get; set; }

        [StringLength(2048)]
        public string OtherAddress { get; set; }

        public int? DefaultAddress { get; set; }

        [Column(TypeName = "ntext")]
        public string Comments { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [StringLength(1024)]
        public string Picture_filename { get; set; }

        public bool Deleted { get; set; }

        public int? Code { get; set; }

        public bool? Active { get; set; }

        [StringLength(256)]
        public string IdNumber { get; set; }

        [StringLength(256)]
        public string Ssn { get; set; }

        public int? PersonType { get; set; }

        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        public string LastName { get; set; }

        [StringLength(256)]
        public string RegCode { get; set; }

        [StringLength(256)]
        public string EcoCode { get; set; }
    }
}
