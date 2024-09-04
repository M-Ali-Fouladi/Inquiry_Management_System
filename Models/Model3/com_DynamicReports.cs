namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DynamicReports
    {
        public int Id { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableCode { get; set; }

        [StringLength(256)]
        public string GroupFieldName { get; set; }

        [StringLength(4)]
        public string GroupDirection { get; set; }

        [StringLength(256)]
        public string SortFieldName { get; set; }

        [StringLength(4)]
        public string SortDirection { get; set; }

        public bool? ShowDate { get; set; }

        public int? PageSize { get; set; }

        public bool? GroupInNewPage { get; set; }

        public bool? IsLandscape { get; set; }

        public bool? SuppressNullRows { get; set; }

        public bool? SuppressZero { get; set; }
    }
}
