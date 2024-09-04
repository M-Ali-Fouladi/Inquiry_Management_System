namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ProclamationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid ProclamationGuid { get; set; }

        public int? PersonnelBaseID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EffectiveDate { get; set; }

        public Guid? TemplateGuid { get; set; }

        public int? IndicatorID { get; set; }

        public int? SequenceNo { get; set; }

        [StringLength(256)]
        public string ProclamationNo { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DrawDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ValidityDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? InsertDate { get; set; }

        public DateTime? RegistrarDate { get; set; }

        public int? ResponsibleID { get; set; }

        public int? ConfirmerID { get; set; }

        public int? ProclamationType { get; set; }

        public bool? Deleted { get; set; }

        public int? IdentityNumber { get; set; }

        public Guid? BatchGuid { get; set; }

        public bool? HasPrintableFile { get; set; }

        public int? WorkflowNo { get; set; }

        public Guid? WorkflowStatus { get; set; }

        public bool? InWorkflow { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int? CommanderID { get; set; }
    }
}
