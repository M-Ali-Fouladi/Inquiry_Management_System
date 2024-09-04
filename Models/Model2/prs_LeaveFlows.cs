namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveFlows
    {
        public int ID { get; set; }

        public int? LeaveID { get; set; }

        public int? ParentID { get; set; }

        public int? ReceiverStaffID { get; set; }

        public string ReceiverComments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public bool? Passed { get; set; }
    }
}
