namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Referrals
    {
        public int ID { get; set; }

        public int ReferenceID { get; set; }

        public int ReferenceFlag { get; set; }

        [StringLength(512)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Post { get; set; }

        [StringLength(128)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [StringLength(1024)]
        public string ReferralRelationTitle { get; set; }
    }
}
