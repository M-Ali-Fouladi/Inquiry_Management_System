namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_BankFormatDetails
    {
        public int ID { get; set; }

        public int BankFormatID { get; set; }

        public int Type { get; set; }

        public int DetailType { get; set; }

        [StringLength(128)]
        public string Value { get; set; }

        public int? Size { get; set; }

        [StringLength(128)]
        public string Perfix { get; set; }

        public int OrderID { get; set; }
    }
}
