namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Persons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public com_Persons()
        {
            com_DiscussionMember = new HashSet<com_DiscussionMember>();
            com_TimelineSubscriber = new HashSet<com_TimelineSubscriber>();
        }

        [Key]
        public Guid Guid { get; set; }

        public bool? Active { get; set; }

        [StringLength(16)]
        public string Code { get; set; }

        [StringLength(128)]
        public string DisplayName { get; set; }

        public DateTime? ModificationDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [StringLength(256)]
        public string Picture_filename { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public Guid? NationalityGuid { get; set; }

        public int? PersonType { get; set; }

        [StringLength(512)]
        public string Comments { get; set; }

        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public Guid? SourceRecordGuid { get; set; }

        public Guid? SourceEntityGuid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(128)]
        public string DomainCode { get; set; }

        public Guid TenantGuid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(128)]
        public string ComputedMergedDisplayName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_DiscussionMember> com_DiscussionMember { get; set; }

        public virtual com_PersonTimelineSync com_PersonTimelineSync { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_TimelineSubscriber> com_TimelineSubscriber { get; set; }
    }
}
