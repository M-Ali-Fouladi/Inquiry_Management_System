namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelEncourageGroups
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? EncourageGroupID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public int? Number { get; set; }

        public decimal? Score { get; set; }
    }
}
