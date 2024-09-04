namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_RangeGroupRanges
    {
        [Key]
        [Column(Order = 0)]
        public Guid RangeGroupGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Title { get; set; }

        public int From { get; set; }

        public int To { get; set; }
    }
}
