namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveTypePreusableMonths
    {
        public int ID { get; set; }

        public int? LeaveTypeID { get; set; }

        public int? RequestMonth { get; set; }

        public int? PreusableMonthsCount { get; set; }
    }
}
