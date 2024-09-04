namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_UserMobileToken
    {
        public int Id { get; set; }

        public Guid UserGuid { get; set; }

        [Required]
        [StringLength(32)]
        public string MobileDeviceID { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
