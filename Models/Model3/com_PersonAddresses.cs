namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonAddresses
    {
        [Key]
        public Guid Guid { get; set; }

        public bool? Active { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        public bool Deleted { get; set; }

        public bool? IsDefault { get; set; }

        public int? PostalCode { get; set; }

        public Guid? AddressTypeGuid { get; set; }

        public Guid? PersonGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
