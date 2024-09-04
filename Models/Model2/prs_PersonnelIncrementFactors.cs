namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelIncrementFactors
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? IncrementFactorID { get; set; }

        public int? Year { get; set; }

        public decimal? Factor { get; set; }
    }
}
