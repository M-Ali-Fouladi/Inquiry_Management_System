namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelContracts_bak940930
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonnelBaseID { get; set; }

        public bool? Active { get; set; }

        [StringLength(128)]
        public string Number { get; set; }

        public int? ContractTypeID { get; set; }

        public int? DurationDays { get; set; }

        public int? DurationMonths { get; set; }

        public int? DurationYears { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public int? Year { get; set; }

        public int? JobID { get; set; }

        [StringLength(2048)]
        public string Comments { get; set; }
    }
}
