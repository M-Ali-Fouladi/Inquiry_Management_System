namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelDependants_bak920509
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonnelBaseID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Index { get; set; }

        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        public string LastName { get; set; }

        public int? Gender { get; set; }

        public int? RelationID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }

        [StringLength(256)]
        public string BirthPlace { get; set; }

        [StringLength(64)]
        public string IDNumber { get; set; }

        [StringLength(64)]
        public string SSN { get; set; }

        public bool? Student { get; set; }

        public int? SchoolGradeID { get; set; }

        public int? EducationLevelID { get; set; }

        public decimal? LastAverage { get; set; }

        public bool? Dependant { get; set; }

        public int? DependencyReasonID { get; set; }

        public int? UndependencyReasonID { get; set; }

        public int? DependencyDegreeID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DependencyQuitDate { get; set; }

        [StringLength(128)]
        public string FatherName { get; set; }

        public int? MaritalStatusID { get; set; }

        public string Description { get; set; }

        [StringLength(128)]
        public string Identifier { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MarryDate { get; set; }

        public bool? Employed { get; set; }
    }
}
