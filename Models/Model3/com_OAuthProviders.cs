namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OAuthProviders
    {
        [Key]
        public Guid Guid { get; set; }

        [Required]
        [StringLength(128)]
        public string BaseUri { get; set; }

        [Required]
        [StringLength(128)]
        public string AuthorizationUri { get; set; }

        [Required]
        [StringLength(128)]
        public string TokenUri { get; set; }

        [Required]
        [StringLength(128)]
        public string ClientID { get; set; }

        [Required]
        [StringLength(128)]
        public string ClientSecret { get; set; }

        [Required]
        [StringLength(128)]
        public string ResponseType { get; set; }

        [Required]
        [StringLength(128)]
        public string RedirectUri { get; set; }

        [Required]
        [StringLength(128)]
        public string ScopeList { get; set; }

        public bool IsAuthenticationProvider { get; set; }
    }
}
