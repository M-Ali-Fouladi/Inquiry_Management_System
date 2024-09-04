namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DiscussionEntry
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        public DateTime CreationTime { get; set; }

        public Guid? MemberGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DiscussionGuid { get; set; }

        public string MessageContent { get; set; }

        public bool Deleted { get; set; }

        public int ContentType { get; set; }

        public int MessageType { get; set; }

        public virtual com_Discussion com_Discussion { get; set; }

        public virtual com_DiscussionMember com_DiscussionMember { get; set; }
    }
}
