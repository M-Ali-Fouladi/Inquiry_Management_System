namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_FormulaEditorLogs
    {
        public int ID { get; set; }

        [StringLength(512)]
        public string StepName { get; set; }

        public bool? InActive { get; set; }

        public DateTime? LastExecution { get; set; }

        public string Execption { get; set; }

        [StringLength(256)]
        public string ItemSelectionName { get; set; }
    }
}
