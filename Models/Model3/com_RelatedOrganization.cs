namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_RelatedOrganization
    {
        public int Id { get; set; }

        public Guid Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(512)]
        public string Email { get; set; }

        [StringLength(2048)]
        public string Url { get; set; }

        public bool Deleted { get; set; }
    }
}
