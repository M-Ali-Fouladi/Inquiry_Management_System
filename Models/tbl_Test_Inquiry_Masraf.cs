namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Test_Inquiry_Masraf
    {
        [Key]
        public long Test_Inquiry_Masraf_ID { get; set; }

        public long? Test_Inquiry_ID { get; set; }

        [StringLength(200)]
        public string Masraf_Name { get; set; }

        [StringLength(10)]
        public string Masraf_Unit { get; set; }

        public long? Test_Inquiry_Masraf_Quantity { get; set; }
    }
}
