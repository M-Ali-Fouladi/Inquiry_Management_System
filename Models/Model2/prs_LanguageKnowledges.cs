namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LanguageKnowledges
    {
        public int ID { get; set; }

        public int ReferenceID { get; set; }

        public int ReferenceFlag { get; set; }

        public int? ForeignLanguageID { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public int? ConversationLevel { get; set; }

        public int? WritingLevel { get; set; }

        public int? UnderstandingLevel { get; set; }

        public int? TranslatingLevel { get; set; }

        public int? OverallLevel { get; set; }

        [StringLength(256)]
        public string LanguageLevel { get; set; }

        [StringLength(512)]
        public string InstituteName { get; set; }

        public int? Index { get; set; }

        public int? ProficiencyLevelID { get; set; }

        public int? RequirementLevelID { get; set; }

        public bool? Active { get; set; }
    }
}
