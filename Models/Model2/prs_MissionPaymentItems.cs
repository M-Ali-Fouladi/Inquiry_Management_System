namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionPaymentItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        [StringLength(128)]
        public string DisplayTitle { get; set; }

        [StringLength(64)]
        public string ParameterName { get; set; }

        public int? OperationalUnitId { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public int? PaymentItemType { get; set; }
    }
}
