namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FiscalYears
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FiscalYear { get; set; }

        public bool Deleted { get; set; }

        public bool? IsCodingClosed { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TenantGuid { get; set; }
    }
}
