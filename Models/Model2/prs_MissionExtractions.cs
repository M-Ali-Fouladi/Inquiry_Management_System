namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionExtractions
    {
        public int ID { get; set; }

        public int? MissionID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int? DecreeNo { get; set; }

        public string Comments { get; set; }

        public decimal? SalaryBase { get; set; }

        public int? TotalMissionPayment { get; set; }

        public int? Status_Back { get; set; }

        public int? Paid { get; set; }

        public bool? Deleted { get; set; }

        public int? WorkingPeriodID { get; set; }

        public int? Year { get; set; }

        public int? MissionBudgetCenterID { get; set; }

        public decimal? DailyMissionPayment { get; set; }

        public decimal? MissionPayment { get; set; }

        public decimal? BadWeatherAmount { get; set; }

        public decimal? DenialOfFacilityAmount { get; set; }

        public decimal? DrivingAmount { get; set; }

        public decimal? TravelCost { get; set; }

        public int? RegisterarUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        public int? LastModificationUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModificationDate { get; set; }

        public Guid Guid { get; set; }

        public Guid? MissionGuid { get; set; }

        public Guid? MissionBudgetCenterGuid { get; set; }

        public Guid? State { get; set; }

        public int? SignedUsersCount { get; set; }

        public int? ExtraRecordID { get; set; }

        public decimal? FoodCostAmount { get; set; }
    }
}
