namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_StandardDisplayColumns
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? ReportGuid { get; set; }

        [StringLength(256)]
        public string ColumnName { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public decimal? Width { get; set; }

        public int? Summary { get; set; }

        public int? Direction { get; set; }

        public int? Position { get; set; }

        public int? DisplayFormat { get; set; }
    }
}
