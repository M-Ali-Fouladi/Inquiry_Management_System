namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelAssignmentLogs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? OfficialPostStructureGuid { get; set; }

        public Guid? OfficialWorkSectionStructureGuid { get; set; }

        public int PersonnelBaseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AssignmentDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EventDate { get; set; }

        public int? UserID { get; set; }

        public int? EventType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OldAssignmentDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OldDismissalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DismissalDate { get; set; }

        [StringLength(64)]
        public string PermissionNo { get; set; }

        public DateTime? PermissionDate { get; set; }

        [StringLength(512)]
        public string PermissionTitle { get; set; }

        public string PermissionComments { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
    }
}
