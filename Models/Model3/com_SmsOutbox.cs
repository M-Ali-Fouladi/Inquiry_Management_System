namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SmsOutbox
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ScheduleTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? SendTime { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DeliverTime { get; set; }

        [StringLength(64)]
        public string Sender { get; set; }

        [StringLength(64)]
        public string Receiver { get; set; }

        [StringLength(2048)]
        public string Body { get; set; }

        public int? ReferenceID { get; set; }

        public int? ReferenceFlag { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? OwnerID { get; set; }

        public byte? OwnerFlag { get; set; }

        public bool? Flash { get; set; }

        public int? Status { get; set; }

        public long? SmsCenterResultID { get; set; }

        public bool? New { get; set; }

        public bool Deleted { get; set; }

        public int? AlertID { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int SmsSenderProviderID { get; set; }
    }
}
