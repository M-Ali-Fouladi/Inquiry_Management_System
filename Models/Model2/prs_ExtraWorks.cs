namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ExtraWorks
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? Type { get; set; }

        public int? DurationType { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public string Comments { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public Guid? BatchID { get; set; }

        public int? RegisterarStaffID { get; set; }

        public int? Status { get; set; }

        public bool? Deleted { get; set; }

        public int? CorrectionID { get; set; }

        public Guid? State { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? CorrectionGuid { get; set; }

        public int? RegisterarUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        public int? LastModificationUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModificationDate { get; set; }

        public Guid? LastDeciderUserGuid { get; set; }
    }
}
