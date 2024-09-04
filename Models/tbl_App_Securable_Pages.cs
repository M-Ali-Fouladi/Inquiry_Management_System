namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_App_Securable_Pages
    {
        [Key]
        public int tbl_SecPageID { get; set; }

        public int? PageID { get; set; }

        public int? GroupID { get; set; }
    }
}
