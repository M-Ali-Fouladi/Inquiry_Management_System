namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncSessionCandidates
    {
        [Key]
        public Guid Guid { get; set; }

        public byte Status { get; set; }
    }
}
