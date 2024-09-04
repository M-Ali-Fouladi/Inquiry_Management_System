namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentDemandedJobs
    {
        public int ID { get; set; }

        public int? EmploymentFormID { get; set; }

        [StringLength(512)]
        public string DemandedJob { get; set; }

        [Column(TypeName = "money")]
        public decimal? DemandedSalary { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReadyToWorkDate { get; set; }
    }
}
