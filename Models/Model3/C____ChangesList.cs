namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("____ChangesList")]
    public partial class C____ChangesList
    {
        public int ID { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(2048)]
        public string Title { get; set; }

        public int? Type { get; set; }

        public string Comments { get; set; }

        public string Url { get; set; }

        public Guid? Guid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? InsertDate { get; set; }

        [StringLength(16)]
        public string PackageVersion { get; set; }

        [StringLength(8)]
        public string DidgahVersion { get; set; }

        public int? DidgahUIVersion { get; set; }
    }
}
