namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_StaffPlans
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }

        public int? LeavePlanID { get; set; }

        public int? ExtraWorkPlanID { get; set; }

        public int? MissionPlanID_Back { get; set; }

        public Guid? MissionPlanGuid_Back { get; set; }

        public Guid? ExtraWorkPlanGuid { get; set; }
    }
}
