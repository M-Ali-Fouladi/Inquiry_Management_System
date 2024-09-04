namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_IndividualPersons
    {
        [Key]
        public Guid Guid { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(32)]
        public string IDNo { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string Ssn { get; set; }

        public Guid? PersonTitleGuid { get; set; }

        public bool Deleted { get; set; }

        [StringLength(512)]
        public string FullName { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
