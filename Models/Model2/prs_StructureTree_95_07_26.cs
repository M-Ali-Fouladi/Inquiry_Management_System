namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_StructureTree_95_07_26
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        public Guid? ParentGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ReferenceGuid { get; set; }

        public int? Type { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime Date { get; set; }

        public int? Order { get; set; }

        public string Hierarchy { get; set; }

        public string DepartmentHierarchyTitle { get; set; }

        public int? OperationalUnitStructureID { get; set; }

        public bool? Deleted { get; set; }

        public Guid? WorkSectionGuid { get; set; }

        public Guid? DepartmentGuid { get; set; }

        public Guid? SynchronizeGuid10 { get; set; }

        public Guid? SynchronizeGuid { get; set; }

        public string Comment { get; set; }
    }
}
