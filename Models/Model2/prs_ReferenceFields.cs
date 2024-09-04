namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ReferenceFields
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(16)]
        public string ExternalCode1 { get; set; }

        [StringLength(16)]
        public string ExternalCode2 { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public bool? UseQuickSearch { get; set; }

        public Guid Guid { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
