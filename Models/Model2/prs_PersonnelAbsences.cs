namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_PersonnelAbsences
    {
        public int ID { get; set; }

        public int PersonnelBaseID { get; set; }

        public bool? Deleted { get; set; }
    }
}
