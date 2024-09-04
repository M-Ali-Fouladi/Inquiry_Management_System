namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeWorkflowProcessHistory
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? BaseGuid { get; set; }

        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateRating { get; set; }

        public int? Order { get; set; }

        public string WorkPlaceIDs { get; set; }

        public string NotWorkPlaceIDs { get; set; }

        public int? JobDegreeID { get; set; }

        public int? NotJobDegreeID { get; set; }

        public string EmploymentTypeIDs { get; set; }

        public string NotEmploymentTypeIDs { get; set; }

        public int? ExpertGradeID { get; set; }

        public int? NotExpertGradeID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? NotEducationLevelID { get; set; }

        public int? PostGradeID { get; set; }

        public int? NotPostGradeID { get; set; }

        public string OfficialWorkSectionStructureGuids { get; set; }

        public string NotOfficialWorkSectionStructureGuids { get; set; }

        public string DecreeTemplateGuids { get; set; }

        public string NotDecreeTemplateGuids { get; set; }

        public int? JobCategoryID { get; set; }

        public int? NotJobCategoryID { get; set; }

        public int? JobFieldID { get; set; }

        public int? NotJobFieldID { get; set; }

        public int? EmploymentStatusID { get; set; }

        public int? NotEmploymentStatusID { get; set; }

        public string OperationalUnitIDs { get; set; }

        public string NotOperationalUnitIDs { get; set; }

        public int? JobStageID { get; set; }

        public int? NotJobStageID { get; set; }

        public string WorkSectionIDs { get; set; }

        public string NotWorkSectionIDs { get; set; }

        public Guid? BasePostGuid { get; set; }

        public Guid? NotBasePostGuid { get; set; }

        public int? JobGradeID { get; set; }

        public int? NotJobGradeID { get; set; }

        public int? JobID { get; set; }

        public int? NotJobID { get; set; }

        public int? ManagerLevelID { get; set; }

        public int? NotManagerLevelID { get; set; }

        public int? FromJobGroupCode { get; set; }

        public int? NotFromJobGroupCode { get; set; }

        public int? ToJobGroupCode { get; set; }

        public int? NotToJobGroupCode { get; set; }

        public int? FromJobBaseCode { get; set; }

        public int? NotFromJobBaseCode { get; set; }

        public int? ToJobBaseCode { get; set; }

        public int? NotToJobBaseCode { get; set; }

        public bool? Deleted { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }
    }
}
