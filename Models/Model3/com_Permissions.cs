namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Permissions
    {
        public int AccessorId { get; set; }

        public int AccessorType { get; set; }

        public Guid SoftwareGuid { get; set; }

        public int ObjectId { get; set; }

        public int ObjectType { get; set; }

        public int AccessCode { get; set; }

        public bool? Value { get; set; }

        public Guid? ObjectGuid { get; set; }

        public int ID { get; set; }
    }
}
