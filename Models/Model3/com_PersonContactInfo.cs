namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonContactInfo
    {
        [Key]
        public Guid Guid { get; set; }

        public bool? Active { get; set; }

        public bool? IsDefault { get; set; }

        public Guid PersonContactTypeGuid { get; set; }

        public Guid? PersonGuid { get; set; }

        [StringLength(128)]
        public string Value { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
