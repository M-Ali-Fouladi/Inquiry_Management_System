namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelExtraGrid1
    {
        public int Id { get; set; }

        [Column("نام دوره")]
        [StringLength(1525)]
        public string نام_دوره { get; set; }

        [Column("تاریخ مستند", TypeName = "smalldatetime")]
        public DateTime? تاریخ_مستند { get; set; }

        public int? RecordID { get; set; }

        [Column("تاریخ شروع", TypeName = "smalldatetime")]
        public DateTime? تاریخ_شروع { get; set; }

        [Column("تاریخ پایان", TypeName = "smalldatetime")]
        public DateTime? تاریخ_پایان { get; set; }

        [Column("مدت به ساعت")]
        public decimal? مدت_به_ساعت { get; set; }

        [Column("نام موسسه")]
        [StringLength(500)]
        public string نام_موسسه { get; set; }

        [Column("نام استاد")]
        [StringLength(500)]
        public string نام_استاد { get; set; }

        [Column("درجه آموزش")]
        [StringLength(500)]
        public string درجه_آموزش { get; set; }

        [Column("درحین خدمت")]
        public bool? درحین_خدمت { get; set; }

        [Column("قابل قبول")]
        public bool? قابل_قبول { get; set; }

        [StringLength(500)]
        public string توضیحات { get; set; }
    }
}
