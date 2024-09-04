namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionRequests_Old_ID_to_Guid_Changes
    {
        public int ID { get; set; }

        public int? MissionID { get; set; }

        public int? Status { get; set; }

        public int? RegisterarUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        public int? LastModificationUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModificationDate { get; set; }
    }
}
