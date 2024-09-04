namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ServiceCalls
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public int? ReferenceFlag { get; set; }

        [Column(TypeName = "xml")]
        public string Parameters { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RunDate { get; set; }

        public string RunResult { get; set; }
    }
}
