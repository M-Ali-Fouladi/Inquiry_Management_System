namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelExtraGrid3
    {
        public int Id { get; set; }

        [Column("نام دوره")]
        [StringLength(1000)]
        public string نام_دوره { get; set; }

        [Column("روز شروع")]
        [StringLength(1000)]
        public string روز_شروع { get; set; }

        [Column("روز پایان")]
        [StringLength(1000)]
        public string روز_پایان { get; set; }

        [Column("مدت ساعت")]
        [StringLength(500)]
        public string مدت_ساعت { get; set; }

        public int? RecordID { get; set; }

        [Column("قابل قبول")]
        public bool? قابل_قبول { get; set; }

        [Column("نوع آموزش")]
        [StringLength(500)]
        public string نوع_آموزش { get; set; }
    }
}
