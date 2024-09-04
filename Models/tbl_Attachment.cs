namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Attachment
    {
        [Key]
        public long Attchment_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Attachment_FullAddress { get; set; }

        public long? Test_Inquiry_ID { get; set; }

        [Column(TypeName = "ntext")]
        public string Attachment_FileName { get; set; }
    }
}
