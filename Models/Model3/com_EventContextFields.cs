namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EventContextFields
    {
        [Key]
        [Column(Order = 0)]
        public Guid EventGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DataType { get; set; }
    }
}
