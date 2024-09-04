namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_SmsProviderReceiverSoftwares
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SmsProviderID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid SoftwareGuid { get; set; }
    }
}
