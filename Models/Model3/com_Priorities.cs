namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Priorities
    {
        public int ID { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public int? DeadlineWarningInterval { get; set; }

        [StringLength(8)]
        public string Color { get; set; }

        public Guid? Guid { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
