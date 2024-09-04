namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_CountryDivisions
    {
        public int ID { get; set; }

        public int? ParentID { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? Level { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public int? CountryID { get; set; }

        public int? ProvinceID { get; set; }

        public int? TownshipID { get; set; }

        public int? RegionID { get; set; }

        public int? VillageID { get; set; }
    }
}
