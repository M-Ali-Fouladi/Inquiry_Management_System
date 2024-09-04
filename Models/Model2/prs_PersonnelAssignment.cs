namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelAssignment
    {
        public int ID { get; set; }

        public Guid? OfficialPostStructureGuid { get; set; }

        public Guid? OfficialWorkSectionStructureGuid { get; set; }

        public int PersonnelBaseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime AssignmentDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DismissalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }
    }
}
