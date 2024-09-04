namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_NumberingGroups_Old
    {
        public int Id { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        public bool Deleted { get; set; }
    }
}
