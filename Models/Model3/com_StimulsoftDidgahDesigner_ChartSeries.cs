namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_ChartSeries
    {
        [Key]
        public Guid Guid { get; set; }

        public int SeriesTypeId { get; set; }

        public Guid? ReportGuid { get; set; }

        public int? StyleId { get; set; }

        [StringLength(256)]
        public string SeriesTitle { get; set; }

        [StringLength(256)]
        public string ValueDataColumn { get; set; }

        [StringLength(256)]
        public string ArgumentDataColumn { get; set; }

        [StringLength(256)]
        public string WeightDataColumn { get; set; }

        [StringLength(256)]
        public string ValueDataColumnOpen { get; set; }

        [StringLength(256)]
        public string ValueDataColumnClose { get; set; }

        [StringLength(256)]
        public string ValueDataColumnHigh { get; set; }

        [StringLength(256)]
        public string ValueDataColumnLow { get; set; }

        public int? SortBy { get; set; }

        public bool? ShowLegend { get; set; }

        public int? AngleLable { get; set; }

        [StringLength(256)]
        public string SeriesTypeTitle { get; set; }
    }
}
