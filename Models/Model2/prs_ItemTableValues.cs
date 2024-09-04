namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemTableValues
    {
        public int? ItemTableID_Back { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal ColumnValue1 { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ColumnValue2 { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ColumnValue3 { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ColumnValue4 { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal ColumnValue5 { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ColumnValue6 { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ColumnValue7 { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ColumnValue8 { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ColumnValue9 { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ColumnValue10 { get; set; }

        public decimal? ReturnValue { get; set; }

        [Key]
        [Column(Order = 10)]
        public Guid ItemTableGuid { get; set; }
    }
}
