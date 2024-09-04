namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_NumberingGroups
    {
        public int Id { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public int? FiscalYear { get; set; }

        public int? FirstIndex { get; set; }

        public int? Type { get; set; }

        public int? PrefixType { get; set; }

        [StringLength(64)]
        public string Prefix { get; set; }

        public int? WarehouseId { get; set; }

        public bool Deleted { get; set; }

        public Guid? WarehouseGuid { get; set; }

        public Guid? FiscalYearGuid { get; set; }
    }
}
