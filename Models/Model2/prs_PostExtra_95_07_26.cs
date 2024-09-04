namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PostExtra_95_07_26
    {
        public int ID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(128)]
        public string PostCode { get; set; }

        public int? JobID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistrationDate { get; set; }

        [Column("DeletePermissionDate ", TypeName = "smalldatetime")]
        public DateTime? DeletePermissionDate_ { get; set; }

        public int? PostGradeID { get; set; }

        public int? PostTypeID { get; set; }

        public int? PostStatus { get; set; }

        public bool? Passed { get; set; }

        public bool? AllOperationalUnitsAccessible_Old { get; set; }

        public int? PostJobCategoryID { get; set; }

        public int? PostJobFieldID { get; set; }

        public int? JobGroupCode { get; set; }

        public int? CommissionStatus { get; set; }

        public int? CommissionType { get; set; }

        public string Comments { get; set; }

        [StringLength(1024)]
        public string FullTitle { get; set; }

        public Guid? Guid { get; set; }

        public int? BudgetCenterID { get; set; }

        public bool? Active { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }

        public int? PostNatureID { get; set; }

        public int? PostOperationalNatureID { get; set; }

        public int? PostLackOfSuctionLevelID { get; set; }

        public bool? Ruling { get; set; }

        public int? NumberPersonUnderDirectSupervisor { get; set; }

        public int? NumberPersonUnderIndirectSupervisor { get; set; }

        [StringLength(256)]
        public string MinimumWorkingDuration { get; set; }

        [StringLength(256)]
        public string CommissionDuration { get; set; }

        public int? ExtraRecordID { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        [Column("_BaseGuid")]
        public Guid? C_BaseGuid { get; set; }

        public Guid? DepartmentGuid_Back { get; set; }

        public int? MinimumTrainingHours { get; set; }

        public Guid? BasePostGuid { get; set; }

        [StringLength(64)]
        public string ExternalCode1 { get; set; }

        public Guid? CostCenterGuid { get; set; }
    }
}
