namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_VoucherSignatureSets
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        [StringLength(8)]
        public string Code { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public Guid? SoftwareGuid { get; set; }
    }
}
