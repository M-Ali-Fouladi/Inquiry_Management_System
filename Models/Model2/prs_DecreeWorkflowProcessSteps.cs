namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeWorkflowProcessSteps
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid DecreeWorkflowProcessGuid { get; set; }

        public int? Order { get; set; }

        public int? StaffID { get; set; }

        public int? Attempter { get; set; }

        public string Actions { get; set; }

        public bool? Responsible { get; set; }

        public int? RespiteDays { get; set; }

        public string CCReceivers { get; set; }
    }
}
