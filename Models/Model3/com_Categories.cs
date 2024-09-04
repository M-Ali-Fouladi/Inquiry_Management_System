namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Categories
    {
        public int Id { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? OwnerId { get; set; }

        [StringLength(8)]
        public string Color { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
