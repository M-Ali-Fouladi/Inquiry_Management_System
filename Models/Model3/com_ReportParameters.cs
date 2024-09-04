namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ReportParameters
    {
        [Key]
        [Column(Order = 0)]
        public Guid ReportGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string TableName { get; set; }

        [Key]
        [Column(Order = 3)]
        public string FieldName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorID { get; set; }

        public string Operand1 { get; set; }

        public string Operand2 { get; set; }

        [StringLength(512)]
        public string Operand1Display { get; set; }

        [StringLength(512)]
        public string Operand2Display { get; set; }
    }
}
