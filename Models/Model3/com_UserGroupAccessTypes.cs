namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserGroupAccessTypes
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserGroupGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AccessType { get; set; }
    }
}
