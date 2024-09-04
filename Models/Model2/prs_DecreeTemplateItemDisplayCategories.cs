namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_DecreeTemplateItemDisplayCategories
    {
        [Key]
        [Column(Order = 0)]
        public Guid DecreeTemplateGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ItemDisplayCategoryGuid { get; set; }

        public bool? SuppressZeroValueForPrintableTemplate { get; set; }

        public bool? DoNotViewValueIfEqualPerviousValue { get; set; }
    }
}
