namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_JobDutyDescriptionDetails-old")]
    public partial class prs_JobDutyDescriptionDetails_old
    {
        public int ID { get; set; }

        public int? JobDutyDescriptionID { get; set; }

        public string Description { get; set; }

        public bool? Deleted { get; set; }

        public Guid? Guid { get; set; }
    }
}
