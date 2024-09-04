namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_AttainmentConditionItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid RetiredTypeGuid { get; set; }

        [StringLength(64)]
        public string ParameterName { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? Logic { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public Guid? ItemGuid { get; set; }
    }
}
