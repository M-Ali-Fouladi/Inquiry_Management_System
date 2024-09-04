namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReferenceMaps
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? SourceSoftwareGuid { get; set; }

        public Guid? TargetSoftwareGuid { get; set; }

        public Guid? SourceEntityGuid { get; set; }

        public Guid? TargetEntityGuid { get; set; }

        public Guid? SourceRecordGuid { get; set; }

        public Guid? TargetRecordGuid { get; set; }

        public bool Deleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
}
