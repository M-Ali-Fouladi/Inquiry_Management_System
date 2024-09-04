namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonTitles_Back
    {
        [Key]
        [Column(Order = 0)]
        public Guid Guid { get; set; }

        public int? Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(16)]
        public string ExternalCode1 { get; set; }

        [StringLength(16)]
        public string ExternalCode2 { get; set; }

        public bool? Active { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Deleted { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ID { get; set; }
    }
}
