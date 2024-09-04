namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_RetrievedEmails
    {
        public int ID { get; set; }

        public int EmailAccountID { get; set; }

        [Required]
        public string EmailUniqueID { get; set; }

        public DateTime RetrieveDate { get; set; }
    }
}
