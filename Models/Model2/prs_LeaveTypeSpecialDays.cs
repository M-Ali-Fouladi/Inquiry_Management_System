namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveTypeSpecialDays
    {
        public int ID { get; set; }

        public Guid Guid { get; set; }

        public int LeaveTypeID { get; set; }

        public Guid LeaveSpecialDayCalendarGuid { get; set; }

        public int DayWorkMinutes { get; set; }
    }
}
