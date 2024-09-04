namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_AdvancedReportHybridColumnElements
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdvancedReportHybridColumnId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ElementType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ElementKey { get; set; }

        public int? OrderIndex { get; set; }

        [StringLength(1)]
        public string Operand { get; set; }

        [StringLength(256)]
        public string DataFieldExpression { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid ElementGuid { get; set; }

        public virtual com_AdvancedReportHybridColumns com_AdvancedReportHybridColumns { get; set; }
    }
}
