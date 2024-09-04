namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelEvaluationGrades_bak921129
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? Year { get; set; }

        public decimal? Score { get; set; }

        public Guid? EvaluationGradeGuid { get; set; }
    }
}
