namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DelegateUsers
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; }

        public Guid DelegateGuid { get; set; }

        public int? DelegateStatus { get; set; }

        public bool? ShowUserInStaffTitle { get; set; }

        public bool? TransferViewAuthorities { get; set; }

        public bool? Confirmed { get; set; }
    }
}
