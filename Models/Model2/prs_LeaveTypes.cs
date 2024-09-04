namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_LeaveTypes
    {
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        public int? StandardLeaveType { get; set; }

        public bool? SuspendsPersonnelStatus { get; set; }

        public bool? DailyAvailable { get; set; }

        public bool? HourlyAvailable { get; set; }

        public int? DayMinHourlyMinutes { get; set; }

        public int? DayMaxHourlyMinutes { get; set; }

        public int MonthMaxHourlyMinutes { get; set; }

        public int MaxContinuousDaysLimit { get; set; }

        public bool? PredefinedRemaining { get; set; }

        public int? MonthlyDaysLimit { get; set; }

        public int? MonthlyXMinsLimit { get; set; }

        public int? MonthlyNXMinsLimit { get; set; }

        public bool? DecreaseAllOnNXOverflow { get; set; }

        public int? DayWorkMinutes { get; set; }

        public bool? DecreaseOnHolidays { get; set; }

        public bool? DecreaseOnExtraWorkDays { get; set; }

        public bool? DecreaseBasedOnMonthWorkingDays { get; set; }

        public bool? IncreaseAbsenceRespiteRemaining { get; set; }

        public bool? MonthPreusable { get; set; }

        public bool? MonthStorable { get; set; }

        public int? YearLimitDays { get; set; }

        public int? YearXferMode { get; set; }

        public int? YearXferLimitDays { get; set; }

        public bool? YearXferValuesSummarize { get; set; }

        public int? YearXferPercentage { get; set; }

        public int? HourlyRequestRegisterRespite { get; set; }

        public int? DailyRequestRegisterRespite { get; set; }

        public int? TemplateFileID { get; set; }

        public bool? Active { get; set; }

        public bool Deleted { get; set; }

        public int? YearHourlyMinsLimit { get; set; }

        public bool? ShiftBaseAvailable { get; set; }

        public bool? HourlyInOFFDayAvailable { get; set; }

        public int DailyCountPerMonth { get; set; }

        public int ShiftBaseCountPerMonth { get; set; }

        public int HourlyCountPerMonth { get; set; }

        public int FirstPresenceRangeHourlyCountPerMonth { get; set; }

        public int FirstPresenceRangeMinHourlyLimit { get; set; }

        public int FirstPresenceRangeMaxHourlyLimit { get; set; }

        public int MiddlePresenceRangeHourlyCountPerMonth { get; set; }

        public int MiddlePresenceRangeMinHourlyLimit { get; set; }

        public int MiddlePresenceRangeMaxHourlyLimit { get; set; }

        public int LastPresenceRangeHourlyCountPerMonth { get; set; }

        public int LastPresenceRangeMinHourlyLimit { get; set; }

        public int LastPresenceRangeMaxHourlyLimit { get; set; }

        public int FirstPresenceRangeLenght { get; set; }

        public int LastPresenceRangeLenght { get; set; }

        public bool? CheckMeritRemainingInUnpayedRequest { get; set; }

        public int MonthMaxDailyDays { get; set; }

        public bool? MonthMaxHourlyStorable { get; set; }

        public bool? IsMonthMaxHourlyStorableToCurrent { get; set; }

        public int? YearXMonthMaxHourlyferLimitHours { get; set; }

        public int? YearXMonthMaxHourlyferMode { get; set; }

        public int WorkingPeriodMaxHourlyMinutes { get; set; }

        public bool? NotRequestAutomaticaly { get; set; }
    }
}
