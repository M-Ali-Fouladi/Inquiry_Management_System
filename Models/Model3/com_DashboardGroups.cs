namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DashboardGroups
    {
        [Key]
        public Guid Guid { get; set; }

        public string Title { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        public Guid? OwnerGuid { get; set; }

        public bool Deleted { get; set; }
    }
}
