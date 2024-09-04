namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TimelineSubscriber
    {
        [Key]
        [Column(Order = 0)]
        public Guid ReferenceGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PersonGuid { get; set; }

        public virtual com_Persons com_Persons { get; set; }
    }
}
