namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_LegalPersons
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(128)]
        public string CompanyName { get; set; }

        public DateTime? CompanyRegistrationDate { get; set; }

        [StringLength(64)]
        public string EconomicCode { get; set; }

        [StringLength(128)]
        public string OldCompanyName { get; set; }

        [StringLength(64)]
        public string RegisterNumber { get; set; }

        public Guid? SupplyStatusGuid { get; set; }

        public Guid? StockStatusGuid { get; set; }

        public Guid? OwnershipTypeGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Deleted { get; set; }

        [StringLength(16)]
        public string EconomicalUniqueIdentifier { get; set; }
    }
}
