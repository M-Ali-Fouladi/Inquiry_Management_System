namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_RepresentingStructure
    {
        public int ID { get; set; }

        public Guid? ParentGuid { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public int? Type { get; set; }

        public int? OrderIndex { get; set; }

        public Guid Guid { get; set; }

        public bool Deleted { get; set; }

        public bool? Synced { get; set; }
    }
}
