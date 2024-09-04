namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ItemTables
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? ItemID_Back { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime EffectiveDate { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName1 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName2 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName3 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName4 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName5 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName6 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName7 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName8 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName9 { get; set; }

        [StringLength(1024)]
        public string ColumnParameterName10 { get; set; }

        public int? ColumnParameterType1 { get; set; }

        public int? ColumnParameterType2 { get; set; }

        public int? ColumnParameterType3 { get; set; }

        public int? ColumnParameterType4 { get; set; }

        public int? ColumnParameterType5 { get; set; }

        public int? ColumnParameterType6 { get; set; }

        public int? ColumnParameterType7 { get; set; }

        public int? ColumnParameterType8 { get; set; }

        public int? ColumnParameterType9 { get; set; }

        public int? ColumnParameterType10 { get; set; }

        public int? ColumnWidth1 { get; set; }

        public int? ColumnWidth2 { get; set; }

        public int? ColumnWidth3 { get; set; }

        public int? ColumnWidth4 { get; set; }

        public int? ColumnWidth5 { get; set; }

        public int? ColumnWidth6 { get; set; }

        public int? ColumnWidth7 { get; set; }

        public int? ColumnWidth8 { get; set; }

        public int? ColumnWidth9 { get; set; }

        public int? ColumnWidth10 { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid ItemGuid { get; set; }
    }
}
