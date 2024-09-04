namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DutyGroups
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(400)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public bool? Active { get; set; }

        [StringLength(32)]
        public string ExternalCode1 { get; set; }
    }
}
