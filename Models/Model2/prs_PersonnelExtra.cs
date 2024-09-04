namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelExtra
    {
        public int ID { get; set; }

        [Column("آخرين مبلغ حقوق سال گذشته")]
        public int? آخرين_مبلغ_حقوق_سال_گذشته { get; set; }

        [Column("آخرين مبلغ افزايش سنواتي سال قبل")]
        public int? آخرين_مبلغ_افزايش_سنواتي_سال_قبل { get; set; }

        [Column("حقوق مبنا سال گذشته")]
        public int? حقوق_مبنا_سال_گذشته { get; set; }

        [Column("مشمول دريافت فوق العاده محل خدمت")]
        public bool? مشمول_دريافت_فوق_العاده_محل_خدمت { get; set; }

        [Column("تعداد روز‌هاي كاركرد سال گذشته")]
        public int? تعداد_روز_هاي_كاركرد_سال_گذشته { get; set; }

        [Column("فيلد 1")]
        public int? فيلد_1 { get; set; }

        [Column("تست رشته")]
        [StringLength(80)]
        public string تست_رشته { get; set; }

        [Column("آخرين مبلغ حقوق مبنا سال گذشته")]
        public int? آخرين_مبلغ_حقوق_مبنا_سال_گذشته { get; set; }

        [Column("آخرين مبلغ افزايش سنواتي سال گذشته")]
        public int? آخرين_مبلغ_افزايش_سنواتي_سال_گذشته { get; set; }

        [Column("تعداد روز هاي كاركرد سال گذشته")]
        public int? تعداد_روز_هاي_كاركرد_سال_گذشته1 { get; set; }

        [Column("سال اجرا")]
        public int? سال_اجرا { get; set; }

        [Column("حقـوق پايـه")]
        public int? حقـوق_پايـه { get; set; }

        public int? پايه { get; set; }

        public int? رتبه { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? تاريخ { get; set; }

        [Column("تاريخ 1", TypeName = "smalldatetime")]
        public DateTime? تاريخ_1 { get; set; }

        public int? قد { get; set; }

        [Column("افزايش سنواتي سال قبل")]
        public int? افزايش_سنواتي_سال_قبل { get; set; }

        public int? تست { get; set; }

        [Column("عدد اعشاری")]
        public decimal? عدد_اعشاری { get; set; }

        [Column("فيلد من 2")]
        public int? فيلد_من_2 { get; set; }

        [Column("نوع بیمه 1")]
        [StringLength(256)]
        public string نوع_بیمه_1 { get; set; }

        [Column("سایز لباس")]
        [StringLength(256)]
        public string سایز_لباس { get; set; }

        [Column("سایز شلوار")]
        [StringLength(256)]
        public string سایز_شلوار { get; set; }

        [Column("سایز کفش")]
        [StringLength(256)]
        public string سایز_کفش { get; set; }

        [Column("نام بانک")]
        [StringLength(256)]
        public string نام_بانک { get; set; }

        [Column("شماره کارت خرید پارسیان")]
        public int? شماره_کارت_خرید_پارسیان { get; set; }

        [Column("شماره حساب")]
        [StringLength(256)]
        public string شماره_حساب { get; set; }

        [StringLength(256)]
        public string هدایا { get; set; }

        [Column("مبلغ سفته")]
        public int? مبلغ_سفته { get; set; }

        [Column("گروه های کاری")]
        [StringLength(256)]
        public string گروه_های_کاری { get; set; }

        [Column("حق بیمه")]
        public int? حق_بیمه { get; set; }

        [Column("شماره کارت پارسیان")]
        [StringLength(256)]
        public string شماره_کارت_پارسیان { get; set; }

        [Column("سوابق آموزشی مدت باعت اعشاری")]
        public int? سوابق_آموزشی_مدت_باعت_اعشاری { get; set; }

        [Column("شماره بیمه")]
        public int? شماره_بیمه { get; set; }

        [Column("پرونده پزشکی")]
        public int? پرونده_پزشکی { get; set; }

        [Column("تایید ارتقاء درجه شغلی")]
        public bool? تایید_ارتقاء_درجه_شغلی { get; set; }

        public int? مسئولیت { get; set; }

        [Column("کوشش فکری")]
        public int? کوشش_فکری { get; set; }

        [Column("تعداد پرسنل")]
        public int? تعداد_پرسنل { get; set; }

        public int? ارتباطات { get; set; }

        [Column("جدید استخدام")]
        public bool? جدید_استخدام { get; set; }

        [Column("امتیاز مدیر عامل")]
        public int? امتیاز_مدیر_عامل { get; set; }

        [Column("تفاوت مبنا")]
        public int? تفاوت_مبنا { get; set; }

        [Column("حق ناهار")]
        public int? حق_ناهار { get; set; }

        [Column("حق موبایل")]
        public int? حق_موبایل { get; set; }

        [Column("سنوات اورندی قبل")]
        public int? سنوات_اورندی_قبل { get; set; }

        [Column("امتیاز آموزش")]
        public int? امتیاز_آموزش { get; set; }

        [Column("کد شغل")]
        [StringLength(250)]
        public string کد_شغل { get; set; }

        [Column("مانده مرخصی در تسویه حساب به ساعت")]
        public int? مانده_مرخصی_در_تسویه_حساب_به_ساعت { get; set; }

        [Column("مانده مرخصی در تسویه حساب به دقیقه")]
        public int? مانده_مرخصی_در_تسویه_حساب_به_دقیقه { get; set; }

        [Column("شعبه سازمان تامین اجتماعی")]
        [StringLength(600)]
        public string شعبه_سازمان_تامین_اجتماعی { get; set; }

        [Column("شماره سازمان تامین اجتماعی")]
        [StringLength(600)]
        public string شماره_سازمان_تامین_اجتماعی { get; set; }

        [Column("شماره کارگاه سازمان تامین اجتماعی")]
        [StringLength(600)]
        public string شماره_کارگاه_سازمان_تامین_اجتماعی { get; set; }

        [Column("تاریخ عضویت در صندوق1", TypeName = "smalldatetime")]
        public DateTime? تاریخ_عضویت_در_صندوق1 { get; set; }

        [Column("پس انداز")]
        public int? پس_انداز { get; set; }

        [Column("تاریخ عضویت در صندوق", TypeName = "smalldatetime")]
        public DateTime? تاریخ_عضویت_در_صندوق { get; set; }

        [Column("ذخیره پس انداز نهایی")]
        public int? ذخیره_پس_انداز_نهایی { get; set; }

        [Column("تعهد انضباطی دارد؟")]
        public bool? تعهد_انضباطی_دارد_ { get; set; }

        [Column("مبلغ کسری اندوخته")]
        public int? مبلغ_کسری_اندوخته { get; set; }

        [Column("هزینه خودرو")]
        public decimal? هزینه_خودرو { get; set; }

        [Column("منطقه کاری")]
        [StringLength(256)]
        public string منطقه_کاری { get; set; }

        [Column("محل استقرار")]
        [StringLength(256)]
        public string محل_استقرار { get; set; }

        [Column("واحد استراتژیک")]
        [StringLength(256)]
        public string واحد_استراتژیک { get; set; }

        [Column("تاریخ انصراف از صندوق", TypeName = "smalldatetime")]
        public DateTime? تاریخ_انصراف_از_صندوق { get; set; }

        [Column("تاریخ استخدام اصلی", TypeName = "smalldatetime")]
        public DateTime? تاریخ_استخدام_اصلی { get; set; }

        [Column("شماره حساب 2")]
        [StringLength(256)]
        public string شماره_حساب_2 { get; set; }

        [Column("پایه سنوات")]
        public decimal? پایه_سنوات { get; set; }

        [Column("مزایای مدیریتی")]
        public decimal? مزایای_مدیریتی { get; set; }

        [Column("10 برابر مزد شغل")]
        public int? C10_برابر_مزد_شغل { get; set; }

        [Column("50 درصد جمع حکم")]
        public int? C50_درصد_جمع_حکم { get; set; }
    }
}
