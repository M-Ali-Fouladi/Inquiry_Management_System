namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Skills
    {
        public int ID { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        [StringLength(1024)]
        public string Skill { get; set; }

        public int? SkillID { get; set; }

        public int? SkillLevelID { get; set; }

        public int? WorkHistory { get; set; }
    }
}
