namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_RepresentingStructureDepartmentDetails
    {
        public int ID { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(128)]
        public string Telephone { get; set; }

        public string Description { get; set; }

        public int? LinkType { get; set; }

        [StringLength(256)]
        public string LinkServerEmail { get; set; }

        [StringLength(256)]
        public string Url { get; set; }

        public Guid? DepartmentGuid { get; set; }

        public int? ReferenceID { get; set; }

        [StringLength(128)]
        public string Title { get; set; }
    }
}
