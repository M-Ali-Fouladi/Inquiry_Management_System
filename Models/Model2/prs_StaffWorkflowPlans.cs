namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_StaffWorkflowPlans
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid StaffGuid { get; set; }

        public Guid WorkflowUseCaseGuid { get; set; }

        public Guid WorkflowPlanGuid { get; set; }
    }
}
