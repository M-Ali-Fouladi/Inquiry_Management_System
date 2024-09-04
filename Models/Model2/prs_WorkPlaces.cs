namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkPlaces
    {
        public int ID { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(128)]
        public string WorkshopNo_Back { get; set; }

        [StringLength(1024)]
        public string EmployerName_Back { get; set; }

        [StringLength(1024)]
        public string Address { get; set; }

        public int? PlaceID { get; set; }

        [StringLength(128)]
        public string PostalCode { get; set; }

        [StringLength(128)]
        public string TelNo { get; set; }

        [StringLength(256)]
        public string FinancialCode { get; set; }

        [StringLength(256)]
        public string RegisterationNo { get; set; }

        [StringLength(1024)]
        public string RegisterationLocation { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        [StringLength(128)]
        public string TaxRegionNo { get; set; }

        [StringLength(128)]
        public string TaxClassNo { get; set; }

        public bool? LearningExpensePayed { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public Guid? WorkshopGuid { get; set; }

        public Guid Guid { get; set; }

        public Guid? TenantGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        [StringLength(16)]
        public string ExternalCode1 { get; set; }

        [StringLength(16)]
        public string ExternalCode2 { get; set; }
    }
}
