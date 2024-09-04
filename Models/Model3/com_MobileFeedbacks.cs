namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_MobileFeedbacks
    {
        public int Id { get; set; }

        public int? OSType { get; set; }

        [StringLength(20)]
        public string OSVersion { get; set; }

        [StringLength(64)]
        public string DeviceID { get; set; }

        [StringLength(256)]
        public string DeviceName { get; set; }

        [StringLength(20)]
        public string DidgahVersion { get; set; }

        [StringLength(64)]
        public string Username { get; set; }

        [StringLength(64)]
        public string ErrorCategory { get; set; }

        [StringLength(64)]
        public string ErrorTag { get; set; }

        [Required]
        [StringLength(64)]
        public string SessionID { get; set; }

        [Required]
        [StringLength(512)]
        public string ErrorMessage { get; set; }

        [Required]
        public string StackTrace { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime ErrorTime { get; set; }

        public string ExtraInfo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime RegistationDate { get; set; }

        [StringLength(30)]
        public string IPAddress { get; set; }

        public bool SendStatus { get; set; }

        [StringLength(256)]
        public string ResultTag { get; set; }

        public string ResultDescription { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ResultDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ResultEnquiryDate { get; set; }

        public Guid? ReferenceSoftwareGuid { get; set; }

        public int? MobileSoftwareFlag { get; set; }
    }
}
