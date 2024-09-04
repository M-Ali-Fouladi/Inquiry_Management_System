namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TrackerSmsConfigs
    {
        public int Id { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(64)]
        public string Number { get; set; }

        public Guid? SoftwareGuid { get; set; }

        [StringLength(32)]
        public string LanguageCode { get; set; }

        public int? TableKey { get; set; }

        public bool Deleted { get; set; }
    }
}
