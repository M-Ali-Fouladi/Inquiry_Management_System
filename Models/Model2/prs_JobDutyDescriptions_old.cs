namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_JobDutyDescriptions-old")]
    public partial class prs_JobDutyDescriptions_old
    {
        public int ID { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public int? JobDutyDescriptionType { get; set; }

        public bool? Deleted { get; set; }

        public Guid? Guid { get; set; }
    }
}
