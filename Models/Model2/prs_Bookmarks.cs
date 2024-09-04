namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Bookmarks
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(512)]
        public string FieldName { get; set; }

        public int? FieldType { get; set; }

        public bool? Active { get; set; }

        public int? Type { get; set; }

        public int? RepeatCount { get; set; }

        public bool? UsableInDecreeComment { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public bool? StoreWhenCreateDecree { get; set; }
    }
}
