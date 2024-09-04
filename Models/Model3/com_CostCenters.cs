namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_CostCenters
    {
        public int Id { get; set; }

        public int? CostCenterTypeId { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(40)]
        public string Code { get; set; }

        public Guid Guid { get; set; }

        public Guid TenantGuid { get; set; }
    }
}
