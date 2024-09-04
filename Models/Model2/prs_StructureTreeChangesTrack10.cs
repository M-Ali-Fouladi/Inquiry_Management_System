namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_StructureTreeChangesTrack10
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        public Guid? ReferenceGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime EventDate { get; set; }

        public int? ReferenceType { get; set; }

        public int? EventType { get; set; }

        public DateTime? ApplyDate { get; set; }
    }
}
