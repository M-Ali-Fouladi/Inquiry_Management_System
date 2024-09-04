namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Staff
    {
        public int Id { get; set; }

        public int? ParentStaffId { get; set; }

        [StringLength(128)]
        public string Code { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int? DepartmentId { get; set; }

        public int? OrderIndex { get; set; }

        public bool Deleted { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public int? PermissionTemplateId { get; set; }

        [StringLength(256)]
        public string FullTitle { get; set; }

        public int? SecretarialId { get; set; }

        public int? WorkSectionId { get; set; }

        public int? FinancialCenterId { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? OperationGuid { get; set; }

        [StringLength(64)]
        public string PostCode { get; set; }

        public bool? SubDeptsApprovementResponsible { get; set; }

        public Guid? BatchInsertGuid { get; set; }

        [StringLength(512)]
        public string DisplayTitle { get; set; }

        public Guid? CascadeAccessGuid { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? StaffPersonRelationType { get; set; }

        public Guid? CostCenterGuid { get; set; }

        public bool ShowPersonDisplayNameInFullTitle { get; set; }
    }
}
