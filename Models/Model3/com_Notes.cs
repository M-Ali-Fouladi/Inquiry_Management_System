namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Notes
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public string Text { get; set; }

        public bool? Public { get; set; }

        public int? ReferenceId { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }
    }
}
