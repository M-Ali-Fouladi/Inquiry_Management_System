namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_IndicatorRepositoryPartitionSequences
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public long IndicatorRepositoryPartitionID { get; set; }

        [StringLength(512)]
        public string Comment { get; set; }

        public Guid OwnerStaffGuid { get; set; }

        public bool? Reserved { get; set; }

        public bool? IsGlobal { get; set; }

        public int SequenceNo { get; set; }
    }
}
