namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ProclamationTemplateVersions
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }

        public bool? Deleted { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
