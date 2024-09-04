namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_App_Pages
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PageID { get; set; }

        [StringLength(50)]
        public string PageName { get; set; }

        [StringLength(100)]
        public string PageNameFA { get; set; }

        public int? priority { get; set; }
    }
}
