namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateVersions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Back { get; set; }

        public int Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool Status { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }
    }
}
