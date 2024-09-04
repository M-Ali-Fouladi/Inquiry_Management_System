namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentInterviews
    {
        public int ID { get; set; }

        public int EmploymentFormID { get; set; }

        public int Index { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public int? InterviewerID { get; set; }

        [StringLength(2048)]
        public string Results { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EmploymentDate { get; set; }

        public bool? Confirmation { get; set; }

        public Guid? InterviewTypeGuid { get; set; }

        public bool? Active { get; set; }
    }
}
