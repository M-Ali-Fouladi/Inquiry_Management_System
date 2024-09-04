namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_TermsOfGeographicLocations
    {
        [Key]
        public Guid Guid { get; set; }

        public int? BadWeatherDegrees { get; set; }

        public int? FacilityDenialDegree { get; set; }

        public int? AbsorptionAreas { get; set; }

        public bool? Border { get; set; }

        public DateTime? Date { get; set; }

        public bool? Deleted { get; set; }

        public Guid? CountryDivisionGuid { get; set; }
    }
}
