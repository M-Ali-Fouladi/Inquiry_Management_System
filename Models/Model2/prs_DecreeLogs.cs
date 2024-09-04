namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeLogs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? DecreeID_Back { get; set; }

        public int? Event_Back { get; set; }

        public DateTime? Time { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid DecreeGuid { get; set; }

        public Guid? Event { get; set; }

        public string Comments { get; set; }
    }
}
