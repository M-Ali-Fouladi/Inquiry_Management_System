namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EmailAccountLogs
    {
        public int ID { get; set; }

        public int? EmailAccountID { get; set; }

        public int? Direction { get; set; }

        public DateTime? LogDate { get; set; }

        [StringLength(256)]
        public string LogTitle { get; set; }

        public string LogStatus { get; set; }

        public int? TotalEmailsCount { get; set; }

        public int? NewEmailsCount { get; set; }

        public int? ExistingEmailsCount { get; set; }
    }
}
