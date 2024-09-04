namespace CustomMembershipEF.Models.Model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class prs_WorkExperiences
    {
        public int ID { get; set; }

        public int ReferenceID { get; set; }

        public int ReferenceFlag { get; set; }

        [StringLength(256)]
        public string OrganizationName { get; set; }

        [StringLength(128)]
        public string Post { get; set; }

        public int? Salary { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        [StringLength(512)]
        public string QuitReason { get; set; }

        public bool? InsurancePayed { get; set; }

        [StringLength(128)]
        public string OrganizationPhone { get; set; }

        [StringLength(1024)]
        public string OrganizationAddress { get; set; }

        public int? EmploymentTypeID { get; set; }

        [StringLength(128)]
        public string Status { get; set; }

        [StringLength(512)]
        public string WorkPlace { get; set; }

        [StringLength(512)]
        public string CityVillage { get; set; }

        [StringLength(512)]
        public string Province { get; set; }

        [StringLength(256)]
        public string Number { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Date { get; set; }
    }
}
