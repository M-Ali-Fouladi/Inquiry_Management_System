namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DiscussionMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public com_DiscussionMember()
        {
            com_DiscussionEntry = new HashSet<com_DiscussionEntry>();
        }

        [Key]
        public Guid Guid { get; set; }

        public bool Active { get; set; }

        public bool Unsubscribed { get; set; }

        public Guid DiscussionGuid { get; set; }

        public int Type { get; set; }

        public Guid PersonGuid { get; set; }

        public virtual com_Discussion com_Discussion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_DiscussionEntry> com_DiscussionEntry { get; set; }

        public virtual com_Persons com_Persons { get; set; }
    }
}
