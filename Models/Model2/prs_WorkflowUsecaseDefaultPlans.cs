namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkflowUsecaseDefaultPlans
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid WorkflowUseCaseGuid { get; set; }

        public Guid WorkflowPlanGuid { get; set; }
    }
}
