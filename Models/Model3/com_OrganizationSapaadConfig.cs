namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_OrganizationSapaadConfig
    {
        public int ID { get; set; }

        public Guid Guid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ModificationDate { get; set; }

        public Guid ModifierUserGuid { get; set; }

        public Guid OrganizationGuid { get; set; }

        public int CorrespondenceHistoryResponseType { get; set; }

        public int ReferenceDocumentResponseType { get; set; }

        public bool DigitalSignatureResponseType { get; set; }
    }
}
