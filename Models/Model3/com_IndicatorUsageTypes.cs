namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_IndicatorUsageTypes
    {
        [Key]
        [Column(Order = 0)]
        public Guid IndicatorGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UsageTypeGuid { get; set; }
    }
}
