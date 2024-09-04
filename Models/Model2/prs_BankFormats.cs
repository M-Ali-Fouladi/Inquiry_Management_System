namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_BankFormats
    {
        public int ID { get; set; }

        public int Type { get; set; }

        public bool? Active { get; set; }

        [Required]
        [StringLength(128)]
        public string Title { get; set; }

        public int FileType { get; set; }

        [StringLength(1)]
        public string Separator { get; set; }
    }
}
