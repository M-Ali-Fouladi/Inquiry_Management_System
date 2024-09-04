namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EntityAttributeValues
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Attribute { get; set; }

        [StringLength(512)]
        public string Value { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
