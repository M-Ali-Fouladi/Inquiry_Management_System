namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ContactLogs
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? ContactID { get; set; }

        public int? Event { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }
    }
}
