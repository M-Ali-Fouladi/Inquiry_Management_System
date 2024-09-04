namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_Notices
    {
        public int ID { get; set; }

        public int? PersonnelBaseID { get; set; }

        public int? NoticeGroup { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        [StringLength(256)]
        public string Subject { get; set; }

        public string Comments { get; set; }

        public int? NotifierStaffID { get; set; }

        [StringLength(2048)]
        public string NotificationInfo { get; set; }

        public bool? Deleted { get; set; }

        [StringLength(1024)]
        public string ExternalNotifier { get; set; }

        [StringLength(128)]
        public string PollingNo { get; set; }

        [StringLength(128)]
        public string UnitReporter { get; set; }

        public int? ExtraRecordID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ExpireDate { get; set; }

        public Guid? NoticeTypeGuid { get; set; }

        public Guid? NoticeCauseGuid { get; set; }

        public Guid Guid { get; set; }

        public Guid? NoticeCauseGroupsGuid { get; set; }

        public Guid? NoticeTypeGroupsGuid { get; set; }
    }
}
