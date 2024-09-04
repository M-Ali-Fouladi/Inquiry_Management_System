namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentFormLogs
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int EmploymentFormID { get; set; }

        public int Event { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        public int? Status { get; set; }
    }
}
