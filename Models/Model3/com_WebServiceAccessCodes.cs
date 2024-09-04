namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_WebServiceAccessCodes
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? ExternalSystemGuid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public Guid? AccessCodeGuid { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public bool Deleted { get; set; }
    }
}
