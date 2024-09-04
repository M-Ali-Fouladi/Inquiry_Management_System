namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Missions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? MissionTypeID { get; set; }

        [StringLength(1024)]
        public string MissionPlaceDestination { get; set; }

        [StringLength(256)]
        public string MissionSubject { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DemandDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public string Comments { get; set; }

        [StringLength(256)]
        public string Hierarchy { get; set; }

        public Guid? BatchID { get; set; }

        public int? RegisterarStaffID { get; set; }

        public bool? Deleted { get; set; }

        public int? CorrectionID { get; set; }

        public bool? Cancelled { get; set; }

        public int? IndicatorID { get; set; }

        public int? SequenceNo { get; set; }

        public int? MissionPlaceDestinationID { get; set; }

        public int? TargetOrganizationID { get; set; }

        public int? MissionPlaceSourceID { get; set; }

        public bool? HasPrintableFile { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? MissionTypeGuid { get; set; }

        public Guid? MissionPlaceSourceGuid { get; set; }

        public Guid? MissionPlaceDestinationGuid { get; set; }

        public Guid? TargetOrganizationGuid { get; set; }

        public Guid? CorrectionGuid { get; set; }

        public Guid? State { get; set; }

        public int? RegisterarUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? RegisterationDate { get; set; }

        public int? LastModificationUserID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LastModificationDate { get; set; }

        public string CancellationComments { get; set; }

        public Guid? CancellationState { get; set; }

        public bool? Accommodation { get; set; }

        public int? SignedUsersCount { get; set; }

        public int? ExtraRecordID { get; set; }

        public int? ShiftCoverType { get; set; }

        public Guid? IndicatorGuid { get; set; }

        public Guid? LastDeciderUserGuid { get; set; }

        public int? PendingArrears { get; set; }
    }
}
