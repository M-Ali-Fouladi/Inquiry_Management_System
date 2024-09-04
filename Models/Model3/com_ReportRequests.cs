namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReportRequests
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(256)]
        public string ReportTitle { get; set; }

        public int? ReportType { get; set; }

        [StringLength(256)]
        public string ReportFilename { get; set; }

        [StringLength(32)]
        public string OutputType { get; set; }

        [StringLength(32)]
        public string Destination { get; set; }

        [StringLength(1024)]
        public string DestinationExtraInfo { get; set; }

        public int? UserID { get; set; }

        [StringLength(32)]
        public string SessionID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RequestDate { get; set; }

        public string RequestParameters { get; set; }

        public bool? ViewAllowed { get; set; }

        [StringLength(64)]
        public string DBDataSource { get; set; }

        [StringLength(64)]
        public string DBInitialCatalog { get; set; }

        [StringLength(8)]
        public string DBPrefix { get; set; }

        [StringLength(64)]
        public string DBUserID { get; set; }

        [StringLength(64)]
        public string DBPassword { get; set; }

        public int? DBConnectTimeout { get; set; }

        public int? DBQueryTimeout { get; set; }
    }
}
