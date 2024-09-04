namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DepartmentExtraHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid Guid { get; set; }

        public Guid BaseGuid { get; set; }

        [Column("_EffectiveDate", TypeName = "smalldatetime")]
        public DateTime? C_EffectiveDate { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(512)]
        public string FullTitle { get; set; }

        public string Comments { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModificationDate { get; set; }

        public int? Flag { get; set; }

        public int? GeographicalLocationID { get; set; }

        [StringLength(64)]
        public string Code { get; set; }

        [StringLength(64)]
        public string MainUnitCode { get; set; }

        public int? PermittedUnitCount { get; set; }

        public int? MaxPermittedPost { get; set; }

        public string Address { get; set; }

        [StringLength(64)]
        public string Phone { get; set; }

        [StringLength(64)]
        public string Fax { get; set; }

        [StringLength(256)]
        public string InternetAddress { get; set; }

        [StringLength(16)]
        public string PostalCode { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(64)]
        public string EconomicNo { get; set; }

        [StringLength(64)]
        public string TaxClassifiedsNo { get; set; }

        [StringLength(64)]
        public string TaxAreasNo { get; set; }

        public int? UnitLevelID { get; set; }

        public int? BudgetCenterID { get; set; }

        public int? UnitStatusID { get; set; }

        public int? UnitTypeID { get; set; }

        public int? OperationalNatureID { get; set; }

        public int? DepartmentNatureID { get; set; }

        public bool? Active { get; set; }

        public bool? Adjutancy { get; set; }

        public int? ExtraRecordID { get; set; }

        [Column("_Comment")]
        public string C_Comment { get; set; }

        [StringLength(64)]
        public string ExternalCode1 { get; set; }

        [StringLength(64)]
        public string UniqueIdentifier { get; set; }
    }
}
