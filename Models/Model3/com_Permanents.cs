namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Permanents
    {
        public int Id { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public byte TypeNo { get; set; }

        [StringLength(32)]
        public string Parameter { get; set; }

        public byte? OrderIndex { get; set; }

        public bool Deleted { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? AvailableOnMobile { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
