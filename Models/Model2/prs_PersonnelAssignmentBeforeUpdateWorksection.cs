namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelAssignmentBeforeUpdateWorksection
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        public Guid? OfficialPostStructureGuid { get; set; }

        public Guid? OfficialWorkSectionStructureGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonnelBaseID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime AssignmentDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DismissalDate { get; set; }
    }
}
