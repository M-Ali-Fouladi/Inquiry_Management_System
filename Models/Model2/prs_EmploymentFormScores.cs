namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentFormScores
    {
        public int ID { get; set; }

        public int EmploymentFormID { get; set; }

        public int? ScoringItemID { get; set; }

        public decimal? Score { get; set; }

        [StringLength(2048)]
        public string Comments { get; set; }
    }
}
