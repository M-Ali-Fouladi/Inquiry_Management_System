namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_MissionTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? Code { get; set; }

        [StringLength(1024)]
        public string Title { get; set; }

        [StringLength(16)]
        public string ExternalCode { get; set; }

        public int? HourlyRequestRegisterRespite { get; set; }

        public int? DailyRequestRegisterRespite { get; set; }

        public int? TemplateFileID { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? StandardMissionType { get; set; }

        public int? MissionDurationType { get; set; }

        public int? MissionPlanID_Back { get; set; }

        public int? MissionPaymentItemID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? MissionPlanGuid_Back { get; set; }

        public Guid? MissionPaymentItemGuid { get; set; }

        public bool? ContinuousHourly { get; set; }

        public Guid? MissionBadWeatherItemGuid { get; set; }

        public Guid? MissionDenialOfFacilityItemGuid { get; set; }

        public Guid? MissionDrivingCostItemGuid { get; set; }

        public Guid? MissionFoodCostItemGuid { get; set; }
    }
}
