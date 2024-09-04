namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Test_Inquiry_Hardware
    {
        [Key]
        public int Test_Inquiry_Hardware_ID { get; set; }

        public long? Test_Inquiry_ID { get; set; }

        [StringLength(100)]
        public string Hardware_ID { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_Program_FromDate { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_FromDate { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_Program_ToDate { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_ToDate { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_Program_FromTime { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_FromTime { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_Program_ToTime { get; set; }

        [StringLength(50)]
        public string Test_Inquiry_Hardware_ToTime { get; set; }

        public string Test_Inquiry_Hardware_Description { get; set; }
    }
}
