namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ExtraModelGuidSearchTemplateFields
    {
        [Key]
        [Column(Order = 0)]
        public Guid TemplateGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FieldGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConditionValue { get; set; }
    }
}
