namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_EmailGroupMembers
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        [StringLength(512)]
        public string Name { get; set; }

        [StringLength(256)]
        public string Email { get; set; }
    }
}
