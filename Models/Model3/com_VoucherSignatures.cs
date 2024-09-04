namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_VoucherSignatures
    {
        [Key]
        [Column(Order = 0)]
        public Guid VoucherSignatureSetGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderIndex { get; set; }

        [StringLength(256)]
        public string Line1 { get; set; }

        [StringLength(256)]
        public string Line2 { get; set; }

        [StringLength(256)]
        public string Line3 { get; set; }
    }
}
