namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TimelineMessage
    {
        [Key]
        public Guid Guid { get; set; }

        public DateTime CreationTime { get; set; }

        [Required]
        public string Data { get; set; }

        public Guid EntityGuid { get; set; }

        public Guid ReferenceGuid { get; set; }

        public Guid ActionTypeGuid { get; set; }

        public bool Deleted { get; set; }
    }
}
