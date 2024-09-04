namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelFormSettings
    {
        [Key]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(256)]
        public string FieldName { get; set; }

        public bool? SendAlertAfterUpdate { get; set; }

        public bool? SystemField { get; set; }

        public bool? DoNotDisplayInPersonnelForm { get; set; }

        [StringLength(256)]
        public string UpdateParameterName { get; set; }

        public bool? IsMandatory { get; set; }

        public int? FieldType { get; set; }

        public bool? DecreeDrawPrerequisite { get; set; }
    }
}
