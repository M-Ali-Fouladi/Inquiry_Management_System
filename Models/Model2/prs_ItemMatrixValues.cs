namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemMatrixValues
    {
        public int? ItemMatrixID_Back { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal RowValue { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ColumnValue { get; set; }

        public decimal? ReturnValue { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid ItemMatrixGuid { get; set; }
    }
}
