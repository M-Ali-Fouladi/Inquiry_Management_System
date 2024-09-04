namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelExtraGrid4
    {
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? تاریخ1 { get; set; }

        [Column("مبلغ پس انداز")]
        public int? مبلغ_پس_انداز { get; set; }

        public int? RecordID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? تاریخ { get; set; }

        [Column("نوع سند واریزی")]
        [StringLength(100)]
        public string نوع_سند_واریزی { get; set; }
    }
}
