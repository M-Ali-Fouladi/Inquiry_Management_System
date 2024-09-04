namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelSaveConditionsSettings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid ItemGuid { get; set; }

        public string Comment { get; set; }

        public bool? Active { get; set; }

        public int? Logic { get; set; }

        public bool? Deleted { get; set; }
    }
}
