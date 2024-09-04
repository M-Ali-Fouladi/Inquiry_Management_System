namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Discussion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public com_Discussion()
        {
            com_DiscussionEntry = new HashSet<com_DiscussionEntry>();
            com_DiscussionMember = new HashSet<com_DiscussionMember>();
        }

        [Key]
        public Guid Guid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public Guid EntityGuid { get; set; }

        public Guid ReferenceGuid { get; set; }

        public bool NonMembersCanBeMentioned { get; set; }

        public bool Archived { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_DiscussionEntry> com_DiscussionEntry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_DiscussionMember> com_DiscussionMember { get; set; }
    }
}
