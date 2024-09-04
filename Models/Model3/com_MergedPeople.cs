namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_MergedPeople
    {
        [Key]
        public Guid Guid { get; set; }

        public DateTime? RegisterationDate { get; set; }

        public Guid? SourcePersonGuid { get; set; }

        public Guid? TargetPersonGuid { get; set; }

        public Guid? UserGuid { get; set; }

        public Guid? RequestGuid { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public int? PersonType { get; set; }
    }
}
