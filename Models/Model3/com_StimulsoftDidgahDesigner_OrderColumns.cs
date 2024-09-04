namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_OrderColumns
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

        public int? SortDirection { get; set; }

        public string ColumnExpression { get; set; }
    }
}
