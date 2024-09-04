namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_Reports
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [StringLength(16)]
        public string Code { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public string QueryBody { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateUser { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? LastModifiedUser { get; set; }

        public bool? PublicView { get; set; }

        public bool? PublicEdit { get; set; }

        public int? QueryType { get; set; }

        public int? Type { get; set; }

        public byte[] File { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? EntityGuid { get; set; }

        [StringLength(256)]
        public string ParentTable { get; set; }

        public bool? Deleted { get; set; }

        public Guid? GroupGuid { get; set; }

        public Guid? CategoryGuid { get; set; }

        public bool? Hidden { get; set; }
    }
}
