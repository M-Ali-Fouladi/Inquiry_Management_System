namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_EmploymentTypeGroupEmploymentTypes
    {
        [Key]
        [Column(Order = 0)]
        public Guid EmploymentTypeGroupGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmploymentTypeID { get; set; }
    }
}
