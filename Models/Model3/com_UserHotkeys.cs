namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserHotkeys
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KeyCode { get; set; }

        public bool? Ctrl { get; set; }

        public bool? Alt { get; set; }

        public bool? Shift { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte ActionType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(512)]
        public string Value { get; set; }
    }
}
