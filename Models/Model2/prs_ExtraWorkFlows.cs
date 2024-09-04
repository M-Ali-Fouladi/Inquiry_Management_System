namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ExtraWorkFlows
    {
        public int ID { get; set; }

        public int? ExtraWorkID { get; set; }

        public int? ParentID { get; set; }

        public int? ReceiverStaffID { get; set; }

        public string ReceiverComments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public bool? Passed { get; set; }

        public Guid Guid { get; set; }

        public Guid? ExtraWorkGuid { get; set; }

        public Guid? ParentGuid { get; set; }
    }
}
