namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DataListUserSettings
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid DataListGuid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(256)]
        public string Key { get; set; }

        public int KeyType { get; set; }

        [Column(TypeName = "xml")]
        public string Value { get; set; }
    }
}
