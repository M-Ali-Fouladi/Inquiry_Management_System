namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Indicators
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public int Code { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(64)]
        public string DisplayFormat { get; set; }

        public Guid DepartmentGuid { get; set; }

        public Guid SoftwareGuid { get; set; }

        public Guid ReferenceEntityGuid { get; set; }

        public Guid IndicatorRepositoryGuid { get; set; }

        public Guid? OperationGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
