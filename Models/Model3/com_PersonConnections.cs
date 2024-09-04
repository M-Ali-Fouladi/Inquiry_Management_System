namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonConnections
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? PersonGuid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? EntityGuid { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int? ReferenceFlag { get; set; }

        public string Description { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }
    }
}
