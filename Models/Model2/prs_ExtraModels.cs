namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_ExtraModels
    {
        public int ID { get; set; }

        public int? TableCode { get; set; }

        [StringLength(256)]
        public string Name { get; set; }

        public int? DataType { get; set; }

        public int? Size { get; set; }

        public bool? Required { get; set; }

        public bool? IsTitle { get; set; }

        public bool? IsListed { get; set; }

        public bool? IsShowed { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsUnique { get; set; }

        public bool? ExactSearch { get; set; }

        public int? Index { get; set; }

        [StringLength(8)]
        public string ListWidth { get; set; }

        [StringLength(8)]
        public string EditWidth { get; set; }

        [StringLength(1024)]
        public string DefaultValue { get; set; }

        public int? GroupID { get; set; }

        public int? ReferenceID { get; set; }

        public string Comments { get; set; }

        [StringLength(2048)]
        public string ExtraInfo { get; set; }
    }
}
