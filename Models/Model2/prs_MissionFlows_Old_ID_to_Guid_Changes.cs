namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionFlows_Old_ID_to_Guid_Changes
    {
        public int ID { get; set; }

        public int? MissionFlowID { get; set; }

        public int? ParentID { get; set; }

        public int? ReceiverStaffID { get; set; }

        [Column(TypeName = "ntext")]
        public string ReceiverComments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public bool? Passed { get; set; }

        public int? MissionFlowType { get; set; }

        public bool? Signed { get; set; }
    }
}
