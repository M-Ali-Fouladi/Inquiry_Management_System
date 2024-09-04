namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_GatewayItemsReferences
    {
        public Guid? Guid { get; set; }

        public int ID { get; set; }

        public Guid? ObjectGuid { get; set; }

        public Guid? GatewayItemGuid { get; set; }

        public int? LastStatus { get; set; }
    }
}
