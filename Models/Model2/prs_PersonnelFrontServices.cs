namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelFrontServices
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? EducationLevelID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public int? DurationDays { get; set; }

        public int? DurationMonths { get; set; }

        public int? DurationYears { get; set; }

        public bool? VoluntaryService { get; set; }

        [StringLength(2048)]
        public string Comments { get; set; }

        public int? Continuity { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PresentationDate { get; set; }
    }
}
