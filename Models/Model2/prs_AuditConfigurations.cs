namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_AuditConfigurations
    {
        public int ID { get; set; }

        public Guid? EntityGuid { get; set; }

        public bool? Inserted { get; set; }

        public bool? Updated { get; set; }

        public bool? Deleted { get; set; }
    }
}
