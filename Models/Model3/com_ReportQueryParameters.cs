namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReportQueryParameters
    {
        [Key]
        [Column(Order = 0)]
        public Guid ReportGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid TypeGuid { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Required { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Context { get; set; }
    }
}
