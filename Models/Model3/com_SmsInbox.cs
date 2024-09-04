namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SmsInbox
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Time { get; set; }

        [StringLength(64)]
        public string Sender { get; set; }

        [StringLength(64)]
        public string Receiver { get; set; }

        [StringLength(2048)]
        public string Body { get; set; }

        public bool? Processed { get; set; }

        public bool? New { get; set; }

        public bool Deleted { get; set; }
    }
}
