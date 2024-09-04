namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeChangesTrack
    {
        public int ID { get; set; }

        public Guid DecreeGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }
    }
}
