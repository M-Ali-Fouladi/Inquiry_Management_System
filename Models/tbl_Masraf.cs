namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Masraf
    {
        [Key]
        public long Masraf_ID { get; set; }

        [StringLength(50)]
        public string Masraf_Name { get; set; }

        [StringLength(50)]
        public string Masraf_Unit { get; set; }

        public int? Masraf_Quantity { get; set; }
    }
}
