namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice
    {
        public double? PersonnelNo { get; set; }

        [Column("علت انضباطی")]
        [StringLength(255)]
        public string علت_انضباطی { get; set; }

        [Column("نوع انضباطی")]
        [StringLength(255)]
        public string نوع_انضباطی { get; set; }

        [StringLength(255)]
        public string تاريخ { get; set; }

        [Key]
        public bool توضيحات { get; set; }

        [Column(" نوع سابقه انضباطی")]
        [StringLength(255)]
        public string C_نوع_سابقه_انضباطی { get; set; }
    }
}
