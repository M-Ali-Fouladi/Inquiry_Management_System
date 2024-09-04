namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EventFlowcharts
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid EntityGuid { get; set; }

        public Guid EventGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public bool Log { get; set; }

        public string Comments { get; set; }

        public byte[] Xaml { get; set; }

        [StringLength(512)]
        public string Xaml_filename { get; set; }

        public bool Deleted { get; set; }
    }
}
