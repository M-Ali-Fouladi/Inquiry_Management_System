namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Departments
    {
        public int Id { get; set; }

        public int ParentDeptId { get; set; }

        [StringLength(128)]
        public string Code { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public int? OrderIndex { get; set; }

        public byte? Flag { get; set; }

        public string Comments { get; set; }

        public int? LinkMode { get; set; }

        public Guid? RemoteGuid { get; set; }

        [StringLength(256)]
        public string RemoteEmail { get; set; }

        [StringLength(20)]
        public string BureauCode { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public bool Deleted { get; set; }

        public int? SecretarialId { get; set; }

        public int? WorkSectionId { get; set; }

        public int? FinancialCenterId { get; set; }

        public Guid Guid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? OperationGuid { get; set; }

        public int? AccessZoneID { get; set; }

        public Guid? BatchInsertGuid { get; set; }

        public int? SelfContainedDatabasesCount { get; set; }

        public Guid? CascadeAccessGuid { get; set; }

        public Guid? ResponsibleStaffGuid { get; set; }

        [StringLength(128)]
        public string SapadPartyId { get; set; }
    }
}
