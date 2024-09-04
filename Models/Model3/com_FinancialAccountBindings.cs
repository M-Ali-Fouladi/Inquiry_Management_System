namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FinancialAccountBindings
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? AccountCategoryID { get; set; }

        public Guid SourceSoftwareGuid { get; set; }

        public int SourceEntityReferenceFlag { get; set; }

        public int TargetDepartmentID { get; set; }

        public int TargetDBIndex { get; set; }

        public int? FiscalYear { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? AccountCategoryGuid { get; set; }

        public bool Deleted { get; set; }
    }
}
