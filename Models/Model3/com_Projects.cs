namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Projects
    {
        public int ID { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(128)]
        public string Code { get; set; }

        public bool? Active { get; set; }

        public bool Deleted { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
