namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class costcenter2
    {
        public int? OfficialPostID { get; set; }

        [Key]
        public Guid Guid { get; set; }
    }
}
