namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplates
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Back { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool? EffectsWorkHistory { get; set; }

        public bool? Active { get; set; }

        public bool? SuppressZero_Back { get; set; }

        public int? DecreeTemplateFileID { get; set; }

        public int? OperationalUnitID { get; set; }

        public bool? Deleted { get; set; }

        public int? CategoryID_Back { get; set; }

        public int? RowNO { get; set; }

        public int? DecreeTemplateItemTemplateID_Back { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? CategoryGuid { get; set; }

        public bool? SuppressZeroItemsForLadderDecrees { get; set; }

        public bool? UseDecreeWorkflowProcessStep { get; set; }

        public Guid? TenantGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
