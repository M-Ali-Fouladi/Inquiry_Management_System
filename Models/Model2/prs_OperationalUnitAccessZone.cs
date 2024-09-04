namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_OperationalUnitAccessZone
    {
        public int ID { get; set; }

        public int? OperationalUnitID { get; set; }

        public int? AccessZoneID { get; set; }
    }
}
