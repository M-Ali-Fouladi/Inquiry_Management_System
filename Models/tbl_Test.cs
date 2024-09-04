namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Test
    {
        [Key]
        public long Test_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Test_UID { get; set; }

        [StringLength(300)]
        public string Test_Subject { get; set; }

        [StringLength(50)]
        public string Test_Standard_Code { get; set; }

        [StringLength(50)]
        public string Test_Sample_No { get; set; }

        public string Test_Related_HardWare { get; set; }

        [StringLength(50)]
        public string Test_Base_Cost { get; set; }

        public int? Test_Base_Vahed { get; set; }

        public int? Test_Sample_Count { get; set; }
    }
}
