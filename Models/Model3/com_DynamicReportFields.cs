namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DynamicReportFields
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DynamicReportId { get; set; }

        [StringLength(128)]
        public string FieldName { get; set; }

        public int? Index { get; set; }

        public bool? IsGroup { get; set; }

        [StringLength(4)]
        public string SortDirection { get; set; }

        public int? DynamicReportOperation { get; set; }
    }
}
