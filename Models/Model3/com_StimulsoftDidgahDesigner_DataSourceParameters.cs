namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_DataSourceParameters
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? ReportGuid { get; set; }

        [StringLength(256)]
        public string TableName { get; set; }

        [StringLength(256)]
        public string TableAlias { get; set; }

        [StringLength(256)]
        public string ColumnName { get; set; }

        [StringLength(256)]
        public string ParameterName { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public Guid? TypeGuid { get; set; }

        public int? Operator { get; set; }

        [StringLength(512)]
        public string StaticValue { get; set; }

        [StringLength(512)]
        public string StaticTextValue { get; set; }

        public bool? Required { get; set; }

        public int? SystemTypeCode { get; set; }

        public bool? Context { get; set; }

        public string ColumnExpression { get; set; }
    }
}
