namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Drawings
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferenceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReferenceFlag { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ReferenceSoftwareGuid { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public byte[] ContentJpeg { get; set; }
    }
}
