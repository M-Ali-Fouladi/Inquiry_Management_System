namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonContactTypes
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(16)]
        public string Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        public bool? ShowInList { get; set; }

        public bool Deleted { get; set; }

        public int? PersonContactGeneralType { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
