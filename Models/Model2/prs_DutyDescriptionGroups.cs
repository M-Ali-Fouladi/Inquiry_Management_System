namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DutyDescriptionGroups
    {
        public int ID { get; set; }

        public Guid DutyDescriptionGuid { get; set; }

        public Guid DutyGroupGuid { get; set; }
    }
}
