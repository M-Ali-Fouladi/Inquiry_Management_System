namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserData
    {
        public int Id { get; set; }

        public int? PersonId { get; set; }

        [StringLength(512)]
        public string CommandId { get; set; }

        public int? KeyCode { get; set; }

        public bool? Shift { get; set; }

        public bool? Control { get; set; }

        public bool? Alt { get; set; }

        [StringLength(256)]
        public string System { get; set; }

        public bool? ShowInPanel { get; set; }

        public bool? ShowInMenu { get; set; }
    }
}
