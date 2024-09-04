namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ExtraGrids
    {
        public int ID { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(256)]
        public string TableName { get; set; }

        public bool? Active { get; set; }

        [StringLength(128)]
        public string OrderField { get; set; }

        [StringLength(16)]
        public string SortDirection { get; set; }

        public int? DynamicTableType { get; set; }
    }
}
