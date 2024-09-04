namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AdminGroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        
        [Column(Order = 1)]
        [StringLength(50)]
        public string GroupName { get; set; }

       
        public ICollection<tbl_Admin> tbl_Admins { get; set; }
    }
}
