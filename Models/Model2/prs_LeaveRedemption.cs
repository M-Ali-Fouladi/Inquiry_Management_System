namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveRedemption
    {
        public int ID { get; set; }

        public int? PersonnelBaseId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        public string Comments { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public int? LengthDays { get; set; }

        public Guid? BatchId { get; set; }

        public int? RegisterarStaffId { get; set; }

        public int? Status { get; set; }

        public bool? Deleted { get; set; }
    }
}
