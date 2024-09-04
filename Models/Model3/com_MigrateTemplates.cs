namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_MigrateTemplates
    {
        public int ID { get; set; }

        public int? ReferenceFlag { get; set; }

        public int? RegistrarStaffID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public bool? Active { get; set; }

        [StringLength(1024)]
        public string TemplateName { get; set; }

        public string Description { get; set; }

        public int? Code { get; set; }

        public int? EffectiveRow { get; set; }

        public Guid TenantGuid { get; set; }

        public Guid? Guid { get; set; }
    }
}
