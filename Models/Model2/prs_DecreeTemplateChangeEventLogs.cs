namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateChangeEventLogs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid DecreeGuid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RollbackDate { get; set; }

        public bool? PersonnelActive { get; set; }

        public Guid? PersonnelOfficialPostStructureGuid { get; set; }

        public int? PersonnelStaffID { get; set; }

        public int? PersonnelEmploymentStatusID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? PersonnelServiceQuitDate { get; set; }
    }
}
