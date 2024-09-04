namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionPlans_Old
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        public bool? Default { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }
    }
}
