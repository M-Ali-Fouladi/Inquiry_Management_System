namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_UnitDutyDescriptions-old")]
    public partial class prs_UnitDutyDescriptions_old
    {
        public int ID { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public int? UnitDutyDescriptionType { get; set; }

        public bool? Deleted { get; set; }

        public Guid? Guid { get; set; }
    }
}
