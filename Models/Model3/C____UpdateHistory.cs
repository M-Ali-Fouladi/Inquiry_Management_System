namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("____UpdateHistory")]
    public partial class C____UpdateHistory
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int DBChangesSequenceID { get; set; }

        [StringLength(20)]
        public string DatabaseVersion { get; set; }

        public Guid SessionGuid { get; set; }

        public bool RunAfterDatabaseCreation { get; set; }
    }
}
