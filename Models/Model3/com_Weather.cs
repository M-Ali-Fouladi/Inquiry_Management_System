namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Weather
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Key { get; set; }

        [Required]
        public string Priority { get; set; }

        public bool SSL { get; set; }
    }
}
