namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_AssociationDetails
    {
        [Key]
        public Guid Guid { get; set; }

        public Guid AssociationGuid { get; set; }

        public Guid? SubjectStaffGuid { get; set; }

        public Guid ObjectStaffGuid { get; set; }

        public string Hierarchy { get; set; }
    }
}
