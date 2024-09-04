namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DashboardGroupItems
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? GroupGuid { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        public bool Deleted { get; set; }
    }
}
