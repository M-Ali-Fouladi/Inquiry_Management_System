namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_WebServices
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public Guid ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public string Url { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        [StringLength(64)]
        public string Password { get; set; }
    }
}
