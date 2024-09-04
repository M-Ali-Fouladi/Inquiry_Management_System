namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OAuthProviderServices
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid OAuthProviderGuid { get; set; }

        public int TypeID { get; set; }

        [Required]
        [StringLength(512)]
        public string Uri { get; set; }
    }
}
