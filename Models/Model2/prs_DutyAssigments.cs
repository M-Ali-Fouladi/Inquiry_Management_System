namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DutyAssigments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? DutyDescriptionGuid { get; set; }

        public int? SkillLevelID { get; set; }
    }
}
