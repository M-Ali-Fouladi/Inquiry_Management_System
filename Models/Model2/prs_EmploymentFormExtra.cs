namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentFormExtra
    {
        public int ID { get; set; }

        public int? ذكاوت { get; set; }

        [Column("علي انصاري")]
        [StringLength(4)]
        public string علي_انصاري { get; set; }

        [Column("مهارتهاي شغلي")]
        [StringLength(80)]
        public string مهارتهاي_شغلي { get; set; }

        [StringLength(88)]
        public string توضيحات { get; set; }

        [Column("گرايش رشته تحصيلي")]
        [StringLength(40)]
        public string گرايش_رشته_تحصيلي { get; set; }

        [Column("شماره پرسنلي")]
        [StringLength(40)]
        public string شماره_پرسنلي { get; set; }

        [StringLength(40)]
        public string FormNumber { get; set; }

        public int? تست2 { get; set; }

        [StringLength(1024)]
        public string رشته { get; set; }

        [Column("بله/خیر")]
        public bool? بله_خیر { get; set; }

        [Column(TypeName = "image")]
        public byte[] فایل { get; set; }

        [StringLength(1024)]
        public string فایل_filename { get; set; }

        public int? جنسیت { get; set; }

        [Column("چند گزینه‌ای")]
        [StringLength(1024)]
        public string چند_گزینه_ای { get; set; }

        [Column("شمارنده اتوماتیک")]
        public int? شمارنده_اتوماتیک { get; set; }

        [Column("سمت سازمانی")]
        public int? سمت_سازمانی { get; set; }

        [Column("اشخاص عمومی")]
        public int? اشخاص_عمومی { get; set; }

        [Column("تست ليلا")]
        public int? تست_ليلا { get; set; }
    }
}
