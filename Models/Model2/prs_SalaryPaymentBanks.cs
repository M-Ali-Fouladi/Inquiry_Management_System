namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_SalaryPaymentBanks
    {
        public int ID { get; set; }

        [Required]
        [StringLength(16)]
        public string Code { get; set; }

        [Required]
        [StringLength(256)]
        public string Title { get; set; }

        public bool? Active { get; set; }

        public bool? Deleted { get; set; }

        public int? BankFormatId { get; set; }

        [StringLength(64)]
        public string BranchCode { get; set; }

        [StringLength(64)]
        public string OrganizationCode { get; set; }

        public int? PhaseCode { get; set; }

        [StringLength(64)]
        public string AccountNo { get; set; }

        [StringLength(256)]
        public string BranchTitle { get; set; }

        public int? TemplateFileId { get; set; }

        public Guid? TenantGuid { get; set; }

        public Guid? GeneralBankGuid { get; set; }

        public Guid? GeneralBranchGuid { get; set; }
    }
}
