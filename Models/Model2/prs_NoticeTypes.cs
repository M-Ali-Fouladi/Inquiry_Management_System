namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_NoticeTypes
    {
        [Key]
        public Guid Guid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public int? NoticeGroup { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public Guid? NoticeTypeGroupsGuid { get; set; }
    }
}
