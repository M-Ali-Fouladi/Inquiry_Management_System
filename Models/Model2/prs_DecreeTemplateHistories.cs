namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateHistories
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid DecreeTemplateGuid { get; set; }

        [StringLength(256)]
        public string DisplayTitle { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public string Comments { get; set; }

        public bool? EffectsWorkHistory { get; set; }

        public bool GovernmentHistory { get; set; }

        public bool ExperienceHistory { get; set; }

        public bool RetirementHistory { get; set; }

        public bool PrivateSectorHistory { get; set; }

        public bool ThisOrganization { get; set; }

        public bool Related { get; set; }

        public bool HalfTimeWorkHistory { get; set; }

        public bool Manager { get; set; }

        public bool Supervisor { get; set; }

        public bool Insurance { get; set; }

        public bool Appointed { get; set; }

        public Guid? DecreeTemplateItemTemplateGuid { get; set; }

        public bool ExtraWorkHistory1 { get; set; }

        public bool ExtraWorkHistory2 { get; set; }

        public bool ExtraWorkHistory3 { get; set; }

        public bool ExtraWorkHistory4 { get; set; }

        public bool ExtraWorkHistory5 { get; set; }

        public bool ExtraWorkHistory6 { get; set; }

        public bool ExtraWorkHistory7 { get; set; }

        public bool ExtraWorkHistory8 { get; set; }

        public bool ExtraWorkHistory9 { get; set; }

        public bool ExtraWorkHistory10 { get; set; }
    }
}
