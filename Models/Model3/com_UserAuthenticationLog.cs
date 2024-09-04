namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserAuthenticationLog
    {
        public int ID { get; set; }

        public Guid UserGuid { get; set; }

        [StringLength(128)]
        public string IPAddress { get; set; }

        [StringLength(128)]
        public string MachineName { get; set; }

        public DateTime Date { get; set; }

        public bool? Successful { get; set; }

        [StringLength(64)]
        public string Integrity { get; set; }

        public int? IntegrityVersion { get; set; }
    }
}
