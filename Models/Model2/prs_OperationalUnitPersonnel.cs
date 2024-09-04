namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_OperationalUnitPersonnel
    {
        public int ID { get; set; }

        public int OperationalUnitID { get; set; }

        public int PersonnelBaseID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }
    }
}
