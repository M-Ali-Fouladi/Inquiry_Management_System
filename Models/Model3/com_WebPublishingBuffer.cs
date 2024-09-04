namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_WebPublishingBuffer
    {
        public int ID { get; set; }

        [Column(TypeName = "xml")]
        public string XmlContent { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime WebSubmitDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime TransferDate { get; set; }

        [StringLength(16)]
        public string UserIPAddress { get; set; }

        public int? Status { get; set; }
    }
}
