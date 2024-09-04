namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DigitalSignatureVersion
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? SignType { get; set; }

        public int? VersionNum { get; set; }

        public string Fields { get; set; }

        public DateTime? Date { get; set; }
    }
}
