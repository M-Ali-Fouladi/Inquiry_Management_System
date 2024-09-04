namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionDecrees_Old_ID_to_Guid_Changes
    {
        public int ID { get; set; }

        public int? MissionID { get; set; }

        public int? Status { get; set; }

        [StringLength(64)]
        public string DecreeNo { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public bool? Deleted { get; set; }

        public int? RegisterarUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        public int? LastModificationUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModificationDate { get; set; }
    }
}
