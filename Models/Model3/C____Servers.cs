namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("____Servers")]
    public partial class C____Servers
    {
        public int ID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(128)]
        public string ServerName { get; set; }

        [StringLength(128)]
        public string InstanceName { get; set; }

        public bool Deleted { get; set; }
    }
}
