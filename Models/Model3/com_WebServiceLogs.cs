namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_WebServiceLogs
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? WebServiceGuid { get; set; }

        public Guid? MethodGuid { get; set; }

        public DateTime? Date { get; set; }

        public string Summary { get; set; }

        public string Details { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
