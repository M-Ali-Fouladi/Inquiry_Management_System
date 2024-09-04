namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("prs_UnitDutyDescriptionDetails-old")]
    public partial class prs_UnitDutyDescriptionDetails_old
    {
        public int ID { get; set; }

        public int? UnitDutyDescriptionID { get; set; }

        public string Description { get; set; }

        public bool? Deleted { get; set; }

        public Guid? Guid { get; set; }
    }
}
