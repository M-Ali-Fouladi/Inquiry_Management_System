namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_TrackerEnquiries
    {
        public int ID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? TableKey { get; set; }

        [StringLength(64)]
        public string TrackNo { get; set; }

        public int? TrackingMethod { get; set; }

        [StringLength(1024)]
        public string TrackSource { get; set; }

        public string TrackComments { get; set; }

        public int? ResultRecordID { get; set; }

        public int? ResultTrackerID { get; set; }

        public int? ResultStatusID { get; set; }

        public int? ResultTrackStatus { get; set; }
    }
}
