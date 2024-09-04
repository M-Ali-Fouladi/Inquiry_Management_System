namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Jobs
    {
        public int ID { get; set; }

        public int? JobNo { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? JobDegreeID { get; set; }

        public int? RequireLanguageLevel { get; set; }

        [StringLength(32)]
        public string ExternalCode1 { get; set; }

        [StringLength(16)]
        public string ExternalCode2 { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? DegreeID { get; set; }

        public int? CommissionStatusID_Back { get; set; }

        public int? EvaluationLevelID { get; set; }

        public int? EducationLevelID { get; set; }

        public int? ExtraRecordID { get; set; }

        public int? FromJobGroupInterval { get; set; }

        public int? ToJobGroupInterval { get; set; }

        public int? FromJobBaseInterval { get; set; }

        public int? ToJobBaseInterval { get; set; }

        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistrationDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletePermissionDate { get; set; }

        [StringLength(64)]
        public string RegistrationPermissionNo { get; set; }

        [StringLength(64)]
        public string DeletePermissionNo { get; set; }

        [Column("_BaseID")]
        public int? C_BaseID { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        public int? Gender { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
