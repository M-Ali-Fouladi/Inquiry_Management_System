namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Promotions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public int? PersonnelBaseID { get; set; }

        public Guid? BatchGuid { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public string Comment { get; set; }

        public int? WorkflowNo { get; set; }

        public Guid? WorkflowStatus { get; set; }

        public bool? InWorkflow { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ExecutionDate { get; set; }

        [StringLength(32)]
        public string Score { get; set; }

        public int? OfferWorkSectionID { get; set; }

        public int? OfferStaffID { get; set; }

        public Guid? OfferOfficialWorkSectionGuid { get; set; }

        public Guid? OfferOfficialPostGuid { get; set; }

        public int? OfferWorkPlaceID { get; set; }

        public int? ReferentialResponsibilityID { get; set; }

        public byte? ReferentialResponsibilityType { get; set; }

        public int? OfferJobID { get; set; }

        public byte? OfferJobType { get; set; }

        public int? OfferJobCategoryID { get; set; }

        public int? OfferJobFieldID { get; set; }

        public int? IndicatorID { get; set; }

        public int? SequenceNo { get; set; }

        public int? RequesterStaffID { get; set; }

        public int? RequesterWorkSectionID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }

        public int? RequesterPersonnelBaseID { get; set; }

        public int? ApprovedReasonID { get; set; }

        public int? RejectedReasonID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LetterDate { get; set; }

        [StringLength(256)]
        public string LetterNo { get; set; }
    }
}
