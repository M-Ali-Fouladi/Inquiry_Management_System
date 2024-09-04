namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelEvaluationGrades
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? Year { get; set; }

        public decimal? Score { get; set; }

        public Guid? EvaluationGradeGuid { get; set; }

        public Guid Guid { get; set; }

        public Guid? EvaluationPeriodGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreationDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }
    }
}
