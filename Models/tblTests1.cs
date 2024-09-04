namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTests1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string رديف { get; set; }

        [Column("نام آزمون")]
        public string نام_آزمون { get; set; }

        [Column("كد آزمون")]
        public string كد_آزمون { get; set; }

        [Column("شماره استاندارد  روش آزمون")]
        public string شماره_استاندارد__روش_آزمون { get; set; }

        [Column("تعداد نمونه ها جهت انجام آزمون")]
        public string تعداد_نمونه_ها_جهت_انجام_آزمون { get; set; }

        [Column("نام وکد دستگاه مورد استفاده")]
        public string نام_وکد_دستگاه_مورد_استفاده { get; set; }
    }
}
