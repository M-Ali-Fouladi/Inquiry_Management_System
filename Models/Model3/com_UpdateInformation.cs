namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UpdateInformation
    {
        [Key]
        public Guid UpdateGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int Status { get; set; }
    }
}
