namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncFiles
    {
        [Key]
        [Column(Order = 0)]
        public Guid FileGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ReferenceGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid SyncGuid { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(512)]
        public string PackageFileName { get; set; }
    }
}
