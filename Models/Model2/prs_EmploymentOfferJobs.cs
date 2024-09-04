namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentOfferJobs
    {
        public int ID { get; set; }

        public int EmploymentFormID { get; set; }

        [StringLength(1024)]
        public string OfferJob { get; set; }

        public int? JobLevelID { get; set; }
    }
}
