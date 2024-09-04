namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Languages
    {
        public int Id { get; set; }

        [StringLength(8)]
        public string Code { get; set; }

        [StringLength(2048)]
        public string Title { get; set; }

        public bool Direction { get; set; }

        [StringLength(50)]
        public string ContentType { get; set; }
    }
}
