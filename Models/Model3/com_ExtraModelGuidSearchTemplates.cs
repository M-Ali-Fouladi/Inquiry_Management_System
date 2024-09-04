namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExtraModelGuidSearchTemplates
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public Guid TableGuid { get; set; }

        public int? OwnerID { get; set; }

        [StringLength(256)]
        public string Title { get; set; }
    }
}
