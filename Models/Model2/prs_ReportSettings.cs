namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ReportSettings
    {
        public int ID { get; set; }

        public Guid Guid { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool? OfflineMode { get; set; }

        public int? AdvancedReportTableKey { get; set; }

        public Guid? SoftwareGuid { get; set; }
    }
}
