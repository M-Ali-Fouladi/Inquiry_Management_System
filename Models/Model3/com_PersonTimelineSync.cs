namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_PersonTimelineSync
    {
        [Key]
        public Guid PersonGuid { get; set; }

        public DateTime LastSyncDate { get; set; }

        public virtual com_Persons com_Persons { get; set; }
    }
}
