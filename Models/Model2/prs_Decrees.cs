namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Decrees
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EffectiveDate { get; set; }

        public int? TemplateID_Back { get; set; }

        public int? IndicatorID { get; set; }

        public int? SequenceNo { get; set; }

        [StringLength(128)]
        public string EmploymentDocumentNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EmploymentDocumentDate { get; set; }

        [StringLength(1024)]
        public string EmploymentDocumentTitle { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DrawDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ValidityDate { get; set; }

        public int? DecreeJobGroupCode { get; set; }

        public int? ResponsibleID { get; set; }

        public int? ConfirmerID { get; set; }

        public int? WorkingPeriodStandardLength { get; set; }

        public int? Type_Back { get; set; }

        public bool? Approved { get; set; }

        public int? Status_Back { get; set; }

        public bool? Deleted { get; set; }

        public int? IdentityNumber { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovementDate { get; set; }

        public bool? PaymentApproved { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentApprovementDate { get; set; }

        public Guid? BatchGuid { get; set; }

        public int? DecreeJobBaseCode { get; set; }

        [StringLength(256)]
        public string DecreeJobGradeTitle { get; set; }

        [StringLength(16)]
        public string LadderDrawCalculationType { get; set; }

        public int? LadderDecreeTemplateFileID { get; set; }

        public bool? SentForSign { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemsSum { get; set; }

        public int? SingleAffectedDecreeID_Back { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? InsertDate { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? TemplateGuid { get; set; }

        public Guid? SingleAffectedDecreeGuid { get; set; }

        public DateTime? RegistrarDate { get; set; }

        public Guid? Type { get; set; }

        public Guid? Status { get; set; }

        public bool? HasPrintableFile { get; set; }

        [StringLength(256)]
        public string DecreeNo { get; set; }

        public byte? Signed { get; set; }

        public Guid? LadderTemplateVersionsAssignmentsGuid { get; set; }

        public bool? SentToPayroll { get; set; }

        [Column(TypeName = "xml")]
        public string Bookmarks { get; set; }

        [StringLength(128)]
        public string DecreeExpertGradeTitle { get; set; }

        public Guid? DecreeWorkflowProcessGuid { get; set; }

        public int? DecreeWorkflowProcessState { get; set; }

        public Guid? TenantGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public DateTime? SentToPayrollDate { get; set; }
    }
}
