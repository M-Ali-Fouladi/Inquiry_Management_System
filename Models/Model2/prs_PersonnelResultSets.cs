namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelResultSets
    {
        public int ID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? UserID { get; set; }

        public bool? Deleted { get; set; }
    }
}
