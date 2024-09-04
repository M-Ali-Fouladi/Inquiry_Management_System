namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncServerRelatedMobileSoftwares
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid SyncServerGuid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public int MobileSoftwareFlag { get; set; }

        public int MaximumUserCount { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
