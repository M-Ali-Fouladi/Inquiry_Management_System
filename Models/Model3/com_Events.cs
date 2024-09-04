namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Events
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public bool Deleted { get; set; }
    }
}
