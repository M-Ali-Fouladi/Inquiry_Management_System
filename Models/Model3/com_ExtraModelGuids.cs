namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExtraModelGuids
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? TableGuid { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        public int? DataType { get; set; }

        public int? Size { get; set; }

        public bool? Required { get; set; }

        public bool? IsTitle { get; set; }

        public bool? IsListed { get; set; }

        public bool? IsShowed { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsUnique { get; set; }

        public bool? ExactSearch { get; set; }

        public int? Index { get; set; }

        [StringLength(8)]
        public string ListWidth { get; set; }

        [StringLength(8)]
        public string EditWidth { get; set; }

        public string DefaultValue { get; set; }

        public Guid? GroupGuid { get; set; }

        public Guid? ReferenceGuid { get; set; }

        [Column(TypeName = "ntext")]
        public string Comments { get; set; }

        [StringLength(2048)]
        public string ExtraInfo { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public int? Top { get; set; }

        public int? Right { get; set; }
    }
}
