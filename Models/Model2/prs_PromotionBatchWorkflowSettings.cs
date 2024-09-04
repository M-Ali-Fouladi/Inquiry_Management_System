namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PromotionBatchWorkflowSettings
    {
        public int ID { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(512)]
        public string FieldName { get; set; }

        public int? FieldType { get; set; }

        public int? Type { get; set; }

        public bool? CurrentConditions { get; set; }

        public bool? OfferConditions { get; set; }
    }
}
