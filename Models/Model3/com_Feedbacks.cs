namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Feedbacks
    {
        public int Id { get; set; }

        public Guid? SoftwareGuid { get; set; }

        public int? UserId { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(256)]
        public string UserFullName { get; set; }

        [StringLength(15)]
        public string IPAddress { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Detail { get; set; }

        [StringLength(1024)]
        public string ExtraInfo { get; set; }

        public int Status { get; set; }

        [StringLength(256)]
        public string ResultTag { get; set; }

        public string ResultDescription { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ResultDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ResultEnquiryDate { get; set; }
    }
}
