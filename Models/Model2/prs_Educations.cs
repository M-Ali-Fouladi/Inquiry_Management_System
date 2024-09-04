namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Educations
    {
        public int ID { get; set; }

        public int ReferenceID { get; set; }

        public int ReferenceFlag { get; set; }

        public int? EducationCenterID { get; set; }

        public int? EducationLevelID { get; set; }

        public decimal? FinalGrade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        [StringLength(256)]
        public string InstitutePlace { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GraduationDate { get; set; }

        public bool? Active { get; set; }

        public int? FieldTypeID { get; set; }

        public int? EducationLicenseTypeID { get; set; }

        public bool? Confirmation { get; set; }

        public Guid? EducationBranchGuid { get; set; }

        public Guid Guid { get; set; }

        public int? TermTypeId { get; set; }
    }
}
