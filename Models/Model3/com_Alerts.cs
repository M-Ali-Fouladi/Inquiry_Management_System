namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Alerts
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? AlertDate { get; set; }

        public int? PriorityId { get; set; }

        public int? Flag { get; set; }

        [StringLength(64)]
        public string ImageFilename { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public string Body { get; set; }

        public int? ReferenceId { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? OwnerId { get; set; }

        public byte? OwnerFlag { get; set; }

        [StringLength(256)]
        public string SenderTitle { get; set; }

        public bool? New { get; set; }

        public bool? Deletable { get; set; }

        public bool? Dismissed { get; set; }

        public bool? Dismissable { get; set; }

        public bool? OpenReference { get; set; }

        [StringLength(512)]
        public string PriorityTitle { get; set; }

        public Guid? Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public string ExtendedInfo { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public bool Deleted { get; set; }

        public Guid? WorkflowUsecaseGuid { get; set; }

        public bool Published { get; set; }
    }
}
