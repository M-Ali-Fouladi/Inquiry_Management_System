namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_SummonTypeFields
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SummonID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string FieldName { get; set; }

        public int? FieldTypeID { get; set; }

        public int? PersonnelRelativeTableID { get; set; }
    }
}
