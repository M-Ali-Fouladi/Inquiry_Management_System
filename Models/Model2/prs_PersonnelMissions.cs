namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelMissions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? PersonnelID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EmissionDate { get; set; }

        [StringLength(256)]
        public string Place { get; set; }

        [StringLength(1024)]
        public string Subject { get; set; }

        public int? MissionType { get; set; }

        public int? Duration { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public int? DeparcherTime { get; set; }

        [StringLength(256)]
        public string Transport { get; set; }

        [StringLength(256)]
        public string ResponsiblePost { get; set; }

        [StringLength(256)]
        public string ResponsibleName { get; set; }

        public int? PaymentPercent { get; set; }

        public int? ConstPayment { get; set; }

        public int? MissionConstPayment { get; set; }

        public int? MissionTotalPayment { get; set; }

        [StringLength(256)]
        public string Currency { get; set; }

        public int? CurrencyRate { get; set; }

        public bool? CurrencyPayment { get; set; }

        public bool? Deleted { get; set; }

        public int? CurrencyAmount { get; set; }
    }
}
