namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StaffRelationHistoryDetail
    {
        [Key]
        [Column(Order = 0)]
        public Guid StaffRelationHistoryGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string Title { get; set; }
    }
}
