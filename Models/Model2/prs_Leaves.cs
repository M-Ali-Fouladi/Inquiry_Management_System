namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Leaves
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? LeaveTypeID { get; set; }

        public int? DurationType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public string Comments { get; set; }

        public int? LengthDays { get; set; }

        public int? LengthMinutes { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public Guid? BatchID { get; set; }

        public int? RegisterarStaffID { get; set; }

        public int? Status { get; set; }

        public bool? Deleted { get; set; }

        public int? CorrectionID { get; set; }

        public int? StartYear { get; set; }

        public int? StartMonth { get; set; }

        public int? StartDay { get; set; }

        public int? EndYear { get; set; }

        public int? EndMonth { get; set; }

        public int? EndDay { get; set; }

        public Guid Guid { get; set; }

        public int? SequenceNo { get; set; }

        public int? IndicatorID { get; set; }

        public int? ShiftCount { get; set; }

        public Guid? LastDeciderUserGuid { get; set; }

        public int? RegisterarUserID { get; set; }
    }
}
