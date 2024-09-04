namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_OperationalUnits
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        public bool? Active { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(1024)]
        public string Comments { get; set; }

        public bool? Deleted { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
