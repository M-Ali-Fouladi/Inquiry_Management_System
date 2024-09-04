namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemMatrixes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? ItemID_Back { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName { get; set; }

        [StringLength(1024)]
        public string RowParameterName { get; set; }

        public int? ColumnParameterType { get; set; }

        public int? RowParameterType { get; set; }

        [StringLength(2048)]
        public string ColumnParameterValues { get; set; }

        [StringLength(2048)]
        public string RowParameterValues { get; set; }

        public int? MiddleValuesRoundingMethod { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid ItemGuid { get; set; }
    }
}
