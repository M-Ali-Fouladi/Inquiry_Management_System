namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StimulsoftDidgahDesigner_StandardDisplayGroupColumn
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? ReportGuid { get; set; }

        [StringLength(256)]
        public string ColumnName { get; set; }

        [StringLength(256)]
        public string Title { get; set; }
    }
}
