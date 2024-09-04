namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExtraModelSearchTemplates
    {
        public int ID { get; set; }

        public Guid SoftwareGuid { get; set; }

        public int TableKey { get; set; }

        public int? OwnerID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }
    }
}
