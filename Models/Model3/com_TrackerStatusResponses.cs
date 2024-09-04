namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TrackerStatusResponses
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrackerStatusID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrackingMethod { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string LanguageKey { get; set; }

        [StringLength(256)]
        public string Tag { get; set; }

        public string Response { get; set; }
    }
}
