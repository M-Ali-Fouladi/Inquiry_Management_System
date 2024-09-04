namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateCCReceivers
    {
        public int? DecreeTemplateID_Back { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiverID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DecreeTemplateGuid { get; set; }
    }
}
