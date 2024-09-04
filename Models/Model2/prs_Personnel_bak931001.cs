namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Personnel_bak931001
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Column("_BaseID")]
        public int? C_BaseID { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }

        [StringLength(128)]
        public string PersonnelNo { get; set; }

        [StringLength(256)]
        public string EmploymentNo { get; set; }

        [StringLength(256)]
        public string FirstName { get; set; }

        [StringLength(256)]
        public string LastName { get; set; }

        [StringLength(64)]
        public string FatherName { get; set; }

        [StringLength(16)]
        public string IDNumber { get; set; }

        [StringLength(16)]
        public string IDSerial { get; set; }

        [StringLength(128)]
        public string IDPlace { get; set; }

        public int? IDPlaceID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IDDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BirthDate { get; set; }

        [StringLength(128)]
        public string BirthPlace { get; set; }

        [StringLength(16)]
        public string SSN { get; set; }

        public int? Gender { get; set; }

        public int? NationalityID { get; set; }

        public int? ReligionID { get; set; }

        public int? MilitaryStatusID { get; set; }

        public int? MaritalStatusID { get; set; }

        [StringLength(128)]
        public string SpouseJob { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MarriageDate { get; set; }

        public int? ChildrenCount { get; set; }

        public int? EligibleChildrenCount { get; set; }

        public int? DependantCount { get; set; }

        public int? SettlementStatusID { get; set; }

        public int? TitleID { get; set; }

        public string Address { get; set; }

        [StringLength(64)]
        public string HomePhone { get; set; }

        [StringLength(64)]
        public string EmergencyPhone { get; set; }

        [StringLength(64)]
        public string CellPhone { get; set; }

        [StringLength(16)]
        public string PostalCode { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? TrialEmploymentDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EmploymentDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ServiceEnteranceDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ServiceQuitDate { get; set; }

        public int? EmploymentTypeID { get; set; }

        public int? EmploymentStatusID { get; set; }

        [StringLength(64)]
        public string ActiveContractNumber { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActiveContractStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActiveContractEndDate { get; set; }

        public int? ActiveContractTypeID { get; set; }

        public int? LeaveGroupID { get; set; }

        public int? WorkPlaceID { get; set; }

        public int? WorkTurnID { get; set; }

        public int? WorkSectionID { get; set; }

        public int? StaffID { get; set; }

        [StringLength(1024)]
        public string WorkSectionTitle { get; set; }

        [StringLength(512)]
        public string OfficialWorkSectionTitle { get; set; }

        [StringLength(512)]
        public string StaffTitle { get; set; }

        [StringLength(512)]
        public string OfficialPostTitle { get; set; }

        [StringLength(512)]
        public string StaffPureTitle { get; set; }

        [StringLength(512)]
        public string OfficialPostPureTitle { get; set; }

        public int? JobStageID { get; set; }

        public int? JobCategoryID { get; set; }

        public int? JobFieldID { get; set; }

        public int? EnteranceJobGroupCode { get; set; }

        public int? EnteranceJobBaseCode { get; set; }

        public int? EnteranceEmploymentTypeID { get; set; }

        public int? JobGroupCode { get; set; }

        public int? JobBaseCode { get; set; }

        public int? JobGradeID { get; set; }

        public int? EqualJobBaseCode { get; set; }

        public int? EqualJobGradeID { get; set; }

        public int? PostGroupCode { get; set; }

        public int? ExpertGradeID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? DiplomaTypeID { get; set; }

        [StringLength(128)]
        public string GraduationPlace { get; set; }

        public string Compilations { get; set; }

        [StringLength(128)]
        public string JobIDNumber { get; set; }

        public decimal? InjuryPercentage { get; set; }

        public int? SacrificerRelationID { get; set; }

        [StringLength(64)]
        public string CaptivityDuration { get; set; }

        [StringLength(64)]
        public string FrontServiceDuration { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? BasijEnteranceDate { get; set; }

        public int? BasijiTypeID { get; set; }

        [StringLength(64)]
        public string WarPresenceDuration { get; set; }

        [StringLength(64)]
        public string MilitaryDuration { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [StringLength(512)]
        public string Picture_filename { get; set; }

        public int? ExtraRecordID { get; set; }

        public bool? Active { get; set; }

        public int? EmploymentFormID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CurrentUpgradeGroupDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NextUpgradeGroupDate { get; set; }

        [StringLength(64)]
        public string DossierNo { get; set; }

        public bool? Deleted { get; set; }

        public int? FieldTypeID { get; set; }

        public int? OperationalUnitID_Backup { get; set; }

        [StringLength(64)]
        public string FinancialIdentifierCode { get; set; }

        public int? ActiveContractJobID { get; set; }

        [StringLength(128)]
        public string EducationBranch { get; set; }

        [StringLength(64)]
        public string FinalGrade { get; set; }

        [StringLength(64)]
        public string UniversityType { get; set; }

        [StringLength(128)]
        public string SpouseEducation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MilitaryServiceStartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? MilitaryServiceEndDate { get; set; }

        public string MilitaryServiceComment { get; set; }

        public int? RentAmount { get; set; }

        [StringLength(64)]
        public string EmploymentDocumentNo { get; set; }

        [StringLength(512)]
        public string EmploymentDocumentTitle { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EmploymentDocumentDate { get; set; }

        public int? ManagerLevelNumber { get; set; }

        public int? ManagerLevelID { get; set; }

        [StringLength(1024)]
        public string FullName { get; set; }

        [StringLength(1024)]
        public string FullNameReversed { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Guid { get; set; }

        public string OperationalUnitTitles { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        public int? EducationLicenseTypeID { get; set; }

        public int? FirstWorkPlaceID { get; set; }

        public int? SequenceNo { get; set; }

        public Guid? OfficialWorkSectionStructureGuid { get; set; }

        public Guid? OfficialPostStructureGuid { get; set; }

        public Guid? InsuranceTypeGuid { get; set; }

        public Guid? SpouseEducationGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RetirementDate { get; set; }

        [StringLength(128)]
        public string InsuranceNo { get; set; }

        public int? ActiveForeignLanguageID { get; set; }

        public int? ActiveForeignLanguageProficiencyLevelID { get; set; }

        public int? ActiveForeignLanguageRequirementLevelID { get; set; }

        [StringLength(128)]
        public string ActiveForeignLanguageLevelTitle { get; set; }
    }
}
