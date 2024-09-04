namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FileNatures
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? ReferenceFlag { get; set; }

        public bool Deleted { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
