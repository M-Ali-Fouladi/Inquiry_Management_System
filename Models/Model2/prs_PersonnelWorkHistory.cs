namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelWorkHistory
    {
        public int ID { get; set; }

        public int PersonnelBaseID { get; set; }

        [StringLength(512)]
        public string JobTitle { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public int? DurationDays { get; set; }

        public int? DurationMonths { get; set; }

        public int? DurationYears { get; set; }

        public bool? Government { get; set; }

        public bool? Experience { get; set; }

        public bool? Retirement { get; set; }

        [StringLength(512)]
        public string OrganizationName { get; set; }

        public bool? PrivateSector { get; set; }

        public bool? ThisOrganization { get; set; }

        public bool? Related { get; set; }

        public int? EmploymentStatusID { get; set; }

        public bool? Insurance { get; set; }

        public int? EmploymentTypeID { get; set; }

        [StringLength(512)]
        public string WorkPlace { get; set; }

        [StringLength(512)]
        public string CityVillage { get; set; }

        [StringLength(512)]
        public string Province { get; set; }

        [StringLength(1024)]
        public string QuitReason { get; set; }

        [StringLength(256)]
        public string DecreeNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DecreeDate { get; set; }

        public bool? FromUpdate { get; set; }

        public bool? Manager { get; set; }

        public bool? Supervisor { get; set; }

        public int? WorkHistoryEducationLevelID { get; set; }

        public int? JobCategoryID { get; set; }

        public int? JobFieldID { get; set; }

        public bool? UnchangeableDuration { get; set; }

        public bool UpdatedByDecree { get; set; }

        public bool? HalfTime { get; set; }

        public int? WorkPlaceID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PresentationDate { get; set; }

        public bool? Appointed { get; set; }

        public Guid? InsuranceTypeGuid { get; set; }

        public Guid Guid { get; set; }

        public int? JobId { get; set; }

        public int? JobFieldsId { get; set; }

        public Guid? OfficialPostGuid { get; set; }

        public int? StaffId { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool? ExtraWorkHistory1 { get; set; }

        public bool? ExtraWorkHistory2 { get; set; }

        public bool? ExtraWorkHistory3 { get; set; }

        public bool? ExtraWorkHistory4 { get; set; }

        public bool? ExtraWorkHistory5 { get; set; }

        public bool? ExtraWorkHistory6 { get; set; }

        public bool? ExtraWorkHistory7 { get; set; }

        public bool? ExtraWorkHistory8 { get; set; }

        public bool? ExtraWorkHistory9 { get; set; }

        public bool? ExtraWorkHistory10 { get; set; }
    }
}
