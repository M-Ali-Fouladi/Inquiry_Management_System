namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SelectOperations
    {
        public int id { get; set; }

        public int? UserId { get; set; }

        public int? ItemMenuId { get; set; }

        public int? SoftwareId { get; set; }
    }
}
