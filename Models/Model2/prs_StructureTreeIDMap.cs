namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_StructureTreeIDMap
    {
        public int ID { get; set; }

        public Guid? StructureTreeGuid { get; set; }

        public int? IDMap { get; set; }
    }
}
