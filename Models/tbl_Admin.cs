namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdminUserName { get; set; }

      

        [StringLength(100)]
        public string AdminDsc { get; set; }

        public bool? AdminType { get; set; }

        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public tbl_AdminGroup tbl_AdminGroup { get; set; }

    }
}
