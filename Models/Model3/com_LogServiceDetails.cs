namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_LogServiceDetails
    {
        public int ID { get; set; }

        public string ServiceName { get; set; }

        public string SubSystemName { get; set; }
    }
}
