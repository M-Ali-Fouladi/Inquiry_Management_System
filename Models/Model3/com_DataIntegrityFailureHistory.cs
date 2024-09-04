namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_DataIntegrityFailureHistory
    {
        public int ID { get; set; }

        public Guid? ReferenceGuid { get; set; }

        public int? ReferenceID { get; set; }

        [StringLength(1024)]
        public string ReferenceTitle { get; set; }

        [StringLength(1024)]
        public string ReferenceEntityTitle { get; set; }

        [StringLength(64)]
        public string MasterHmac { get; set; }

        [StringLength(64)]
        public string CalculatedHmac { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DetectionDate { get; set; }
    }
}
