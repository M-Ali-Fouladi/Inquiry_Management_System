namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_UnitStatus_Audit
    {
        [Key]
        public int AuditID { get; set; }

        [Required]
        [MaxLength(85)]
        public byte[] UserSID { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(256)]
        public string ApplicationName { get; set; }

        public DateTime AuditDateTime { get; set; }

        public byte ActionType { get; set; }

        public int? ID { get; set; }

        public int? Code { get; set; }

        [StringLength(512)]
        public string Title { get; set; }

        [StringLength(16)]
        public string ExternalCode1 { get; set; }

        [StringLength(16)]
        public string ExternalCode2 { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }
    }
}
