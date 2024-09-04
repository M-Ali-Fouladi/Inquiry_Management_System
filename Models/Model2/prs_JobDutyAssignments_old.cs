namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_JobDutyAssignments-old")]
    public partial class prs_JobDutyAssignments_old
    {
        public int ID { get; set; }

        public int? JobID { get; set; }

        public int? DutyDescriptionID { get; set; }
    }
}
