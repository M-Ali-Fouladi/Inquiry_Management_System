namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_App_Objs
    {
        [Key]
        public int ObjID { get; set; }

        [StringLength(50)]
        public string ObjName { get; set; }

        public int? PageID { get; set; }

        [StringLength(100)]
        public string ObjNameFA { get; set; }
    }
}
