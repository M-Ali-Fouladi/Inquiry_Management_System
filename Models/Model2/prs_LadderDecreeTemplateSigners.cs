namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LadderDecreeTemplateSigners
    {
        [Key]
        [Column(Order = 0)]
        public Guid LadderDecreeGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DecreeLogGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SignerID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SenderID { get; set; }

        public int? SignatureNo { get; set; }

        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        public bool? Deleted { get; set; }
    }
}
