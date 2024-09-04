namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReportTemplates
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid ReportGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public string Comments { get; set; }

        public byte[] TemplateFile { get; set; }

        [StringLength(512)]
        public string TemplateFile_filename { get; set; }
    }
}
