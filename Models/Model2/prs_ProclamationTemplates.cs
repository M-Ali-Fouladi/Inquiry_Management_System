namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ProclamationTemplates
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(256)]
        public string DisplayTitle { get; set; }

        public string Comments { get; set; }

        public int RowNO { get; set; }

        public int? ProclamationType { get; set; }

        public int? OperationalUnitID { get; set; }

        public Guid? CategoryGuid { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? ContractTypeID { get; set; }

        public Guid? TenantGuid { get; set; }
    }
}
