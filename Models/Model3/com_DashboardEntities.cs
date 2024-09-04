namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DashboardEntities
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? OwnerGuid { get; set; }

        public string Title { get; set; }

        public string Config { get; set; }

        public Guid? GroupItemGuid { get; set; }

        public int? Type { get; set; }

        public bool Deleted { get; set; }

        public Guid? EntityGuid { get; set; }
    }
}
