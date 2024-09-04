namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_SacrificialStatusGroupSacrificialStatuses
    {
        [Key]
        [Column(Order = 0)]
        public Guid SacrificialStatusGroupGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SacrificialStatus { get; set; }
    }
}
