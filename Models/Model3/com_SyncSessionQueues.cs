namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SyncSessionQueues
    {
        public int ID { get; set; }

        public int? SyncSessionID { get; set; }

        [StringLength(256)]
        public string PackageFileName { get; set; }

        [StringLength(256)]
        public string TableName { get; set; }

        public int? PackageSize { get; set; }

        public int? RowsCount { get; set; }

        public bool? Downloaded { get; set; }

        public DateTime? DownloadDate { get; set; }
    }
}
