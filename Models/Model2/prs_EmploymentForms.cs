namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentForms
    {
        public int ID { get; set; }

        [StringLength(80)]
        public string FormNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        public string LastName { get; set; }

        [StringLength(256)]
        public string FatherName { get; set; }

        [StringLength(16)]
        public string IDNumber { get; set; }

        [StringLength(256)]
        public string IDPlace { get; set; }

        public int? IDPlaceID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }

        [StringLength(256)]
        public string BirthPlace { get; set; }

        [StringLength(16)]
        public string SSN { get; set; }

        public int? Gender { get; set; }

        public string Address { get; set; }

        [StringLength(512)]
        public string Country { get; set; }

        [StringLength(512)]
        public string City { get; set; }

        [StringLength(128)]
        public string HomePhone { get; set; }

        [StringLength(128)]
        public string WorkPhone { get; set; }

        [StringLength(128)]
        public string CellPhone { get; set; }

        [StringLength(16)]
        public string PostalCode { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public int? NationalityID { get; set; }

        public int? ReligionID { get; set; }

        public int? MilitaryStatusID { get; set; }

        public int? MaritalStatusID { get; set; }

        public int? ChildrenCount { get; set; }

        public int? DependantCount { get; set; }

        public int? SettlementStatusID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? DiplomaTypeID { get; set; }

        [StringLength(256)]
        public string GraduationPlace { get; set; }

        public string Compilations { get; set; }

        public int? WorkSectionID { get; set; }

        public int? WorkPlaceID { get; set; }

        public int? WorkingSchedule_Back { get; set; }

        public string ExtraComments { get; set; }

        public int? LastEditorID { get; set; }

        public int? Status { get; set; }

        public bool? Deleted { get; set; }

        public int? ExtraRecordID { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [StringLength(1024)]
        public string Picture_filename { get; set; }

        [StringLength(128)]
        public string EmergencyPhone { get; set; }

        public decimal? FinalGrade { get; set; }

        [StringLength(128)]
        public string UniversityType { get; set; }

        [StringLength(256)]
        public string FatherJob { get; set; }

        [StringLength(256)]
        public string FatherEducation { get; set; }

        [StringLength(256)]
        public string MotherJob { get; set; }

        [StringLength(256)]
        public string MotherEducation { get; set; }

        [StringLength(256)]
        public string SpouseJob { get; set; }

        [StringLength(256)]
        public string SpouseEducation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MilitaryServiceStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MilitaryServiceEndDate { get; set; }

        public string MilitaryServiceComment { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MarriageDate { get; set; }

        public int? SiblingCount { get; set; }

        public int? RentAmount { get; set; }

        public int? EducationFieldID { get; set; }

        [StringLength(512)]
        public string LicenseTitle { get; set; }

        public Guid? ActiveInterviewTypeGuid { get; set; }

        public int? EmploymentTypeID { get; set; }

        public Guid Guid { get; set; }

        public Guid? SpouseEducationGuid { get; set; }

        public Guid? EducationBranchGuid { get; set; }

        public Guid? NationalityGuid { get; set; }
    }
}
