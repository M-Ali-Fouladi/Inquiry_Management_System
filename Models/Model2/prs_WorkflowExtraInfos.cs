namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkflowExtraInfos
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? WorkflowInstanceGuid { get; set; }

        public Guid? WorkflowPageInfoGuid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int? OrderIndex { get; set; }

        public bool? Terminated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TerminationDate { get; set; }

        public bool? Terminatable { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? InsertDate { get; set; }

        public bool? Viewed { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ViewDate { get; set; }

        public bool? Forwarded { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ForwardDate { get; set; }

        public string Comment { get; set; }

        [StringLength(256)]
        public string SenderTitle { get; set; }

        public Guid? SenderGuid { get; set; }

        public string ToReceiverList { get; set; }

        public string CcReceiverList { get; set; }

        public string OwnerTitle { get; set; }

        public Guid? OwnerGuid { get; set; }

        public int? OwningType { get; set; }

        public Guid? RecordGuid { get; set; }

        public Guid? PriorityGuid { get; set; }

        [StringLength(256)]
        public string PriorityTitle { get; set; }

        public Guid? StateGuid { get; set; }

        public string OwnerComment { get; set; }

        public Guid? WorkflowUseCaseGuid { get; set; }

        public int? WorkflowInstanceStatus { get; set; }

        public Guid? WorkflowInstanceOwnerGuid { get; set; }

        public int? WorkflowStatus { get; set; }

        public Guid? ParentGuid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }
}
