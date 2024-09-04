namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_FinancialActivityTypeFiscalYearDetails
    {
        [Key]
        [Column(Order = 0)]
        public Guid FinancialActivityTypeGuid { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FiscalYearDetailGuid { get; set; }
    }
}
