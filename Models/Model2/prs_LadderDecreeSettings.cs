namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LadderDecreeSettings
    {
        [Key]
        public Guid LadderSettingsGuid { get; set; }

        [StringLength(512)]
        public string Value { get; set; }
    }
}
