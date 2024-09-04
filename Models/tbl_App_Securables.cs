namespace CustomMembershipEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_App_Securables
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tbl_SecID { get; set; }

        public int? ObjID { get; set; }

        public int? GroupID { get; set; }
    }
}
