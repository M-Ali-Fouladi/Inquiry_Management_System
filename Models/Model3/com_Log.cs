namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Log
    {
        public int ID { get; set; }

        public int? ServiceDetailID { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public string Description { get; set; }

        public string Exception { get; set; }

        public DateTime? Date { get; set; }

        public int? Severity { get; set; }

        [StringLength(128)]
        public string IP { get; set; }

        [StringLength(512)]
        public string Url { get; set; }

        public int? UserID { get; set; }

        public int? Origin { get; set; }
    }
}
