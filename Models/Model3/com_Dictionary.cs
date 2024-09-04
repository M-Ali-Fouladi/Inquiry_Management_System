namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Dictionary
    {
        [Key]
        [StringLength(255)]
        public string Word { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
