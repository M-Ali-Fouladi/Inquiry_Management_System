namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DiscussionLog
    {
        [Key]
        public Guid Guid { get; set; }

        public int MemberActivityType { get; set; }

        public Guid DiscussionEntryGuid { get; set; }

        public Guid UserGuid { get; set; }

        public DateTime Time { get; set; }
    }
}
