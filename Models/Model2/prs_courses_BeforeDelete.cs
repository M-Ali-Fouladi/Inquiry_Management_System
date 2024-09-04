namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_courses_BeforeDelete
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferenceID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferenceFlag { get; set; }

        [StringLength(256)]
        public string InstituteName { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(128)]
        public string FinalGrade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public int? DurationHours { get; set; }

        public int? DurationDays { get; set; }

        public int? DurationMonths { get; set; }

        public int? DurationYears { get; set; }

        [StringLength(256)]
        public string InstitutePlace { get; set; }

        [StringLength(2048)]
        public string Comments { get; set; }

        public int? CourseTypeID { get; set; }

        public bool? UnderService { get; set; }

        [StringLength(256)]
        public string DocumentNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DocumentDate { get; set; }

        public bool? Acceptable { get; set; }

        public int? CourseDegreeID { get; set; }

        public int? CourseFieldID { get; set; }

        public Guid? Guid { get; set; }
    }
}
