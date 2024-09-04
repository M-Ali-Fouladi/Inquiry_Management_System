namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_OperationalUnitPersonnelCriteria
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperationalUnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte CriteriaType { get; set; }

        public int? CriteriaID { get; set; }

        public Guid? CriteriaGuid { get; set; }
    }
}
