namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Flows
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? ReferenceId { get; set; }

        public int? ReferenceFlag { get; set; }

        public int? OwnerFlag { get; set; }

        public bool? Linear { get; set; }
    }
}
