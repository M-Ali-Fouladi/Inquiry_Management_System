namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_AdvancedReports
    {
        public int Id { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableKey { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(1024)]
        public string DisplayTitle { get; set; }

        public int? ReportGroupId { get; set; }

        public int? ReportTemplateId { get; set; }

        public int? SortColumnType { get; set; }

        public int? SortColumnKey { get; set; }

        [StringLength(4)]
        public string SortDirection { get; set; }

        public bool? ShowDate { get; set; }

        public bool Deleted { get; set; }

        public Guid? Guid { get; set; }

        public bool? Active { get; set; }

        public Guid? AdvancedReportGroupGuid { get; set; }

        public int? ReportAccessCode { get; set; }

        public Guid? SortColumnGuid { get; set; }
    }
}
