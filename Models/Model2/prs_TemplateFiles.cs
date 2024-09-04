namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_TemplateFiles
    {
        public int ID { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool? Deleted { get; set; }

        public int? TemplateFileType { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
