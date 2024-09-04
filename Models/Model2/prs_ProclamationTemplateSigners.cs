namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ProclamationTemplateSigners
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProclamationGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SignerID { get; set; }

        public int? SignatureNo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        public bool? Deleted { get; set; }
    }
}
