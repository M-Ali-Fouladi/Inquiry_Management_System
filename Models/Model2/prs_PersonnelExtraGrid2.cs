namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelExtraGrid2
    {
        public int Id { get; set; }

        [Column("تاریخ مراجعه به پزشک", TypeName = "smalldatetime")]
        public DateTime? تاریخ_مراجعه_به_پزشک { get; set; }

        [Column("سابقه بیماری خاص")]
        public bool? سابقه_بیماری_خاص { get; set; }

        [Column("تشدید علائم بیماری در محل کار")]
        public bool? تشدید_علائم_بیماری_در_محل_کار { get; set; }

        [Column("حساسیت به ماده خاص")]
        public bool? حساسیت_به_ماده_خاص { get; set; }

        [Column("سابقه بیماری ارثی در خانواده")]
        public bool? سابقه_بیماری_ارثی_در_خانواده { get; set; }

        [Column("سابقه تزریق خون")]
        public bool? سابقه_تزریق_خون { get; set; }

        [Column("سابقه انجام آزمایش خاص")]
        public bool? سابقه_انجام_آزمایش_خاص { get; set; }

        [Column("سابقه عمل جراحی")]
        public bool? سابقه_عمل_جراحی { get; set; }

        public int? RecordID { get; set; }

        [Column("سابقه سرطان در فامیل")]
        public bool? سابقه_سرطان_در_فامیل { get; set; }

        [Column("سابقه داروی خاص")]
        public bool? سابقه_داروی_خاص { get; set; }

        [Column("سیگار می کشید")]
        public bool? سیگار_می_کشید { get; set; }

        [Column("سابقه غیبت از کار به علت بیماری بیش از سه روز")]
        public bool? سابقه_غیبت_از_کار_به_علت_بیماری_بیش_از_سه_روز { get; set; }

        [Column("نظر پزشک11")]
        public bool? نظر_پزشک11 { get; set; }

        [Column("کد آزمایش11")]
        public bool? کد_آزمایش11 { get; set; }

        [Column("سابقه سقط جنین یا نازایی")]
        public bool? سابقه_سقط_جنین_یا_نازایی { get; set; }

        [Column("نظر پزشک")]
        [StringLength(700)]
        public string نظر_پزشک { get; set; }

        [Column("کد آزمایش")]
        public int? کد_آزمایش { get; set; }

        [Column("ارجاع پزشک")]
        [StringLength(500)]
        public string ارجاع_پزشک { get; set; }
    }
}
