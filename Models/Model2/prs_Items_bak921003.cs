namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Items_bak921003
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(64)]
        public string ParameterName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool UsableInDecree { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Deleted { get; set; }

        public bool? SummarizeInSalary { get; set; }

        public int? ItemCategoryID_Back { get; set; }

        public int? ItemOrder { get; set; }

        [StringLength(256)]
        public string DisplayTitle { get; set; }

        public int? OperationalUnitID { get; set; }

        public bool? Active { get; set; }

        public int? DisplayCategoryID_Back { get; set; }

        public bool? RoundInCalculations { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid Guid { get; set; }

        public Guid? ItemCategoryGuid { get; set; }

        public Guid? DisplayCategoryGuid_Back { get; set; }

        public bool? DisplayInDecree { get; set; }
    }
}
