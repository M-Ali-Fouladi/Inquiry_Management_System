namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_Delegates
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Date { get; set; }

        public int? RegistrarUserId { get; set; }

        public int? StaffId { get; set; }

        public int? UserId { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndDate { get; set; }

        public bool? ShowUserInStaffTitle { get; set; }

        public bool? Assigned { get; set; }

        public bool? Unassigned { get; set; }

        public bool? Active { get; set; }

        public bool? TransferViewAuthorities { get; set; }

        public bool? Confirmed { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid? RegistrarUserGuid { get; set; }

        public Guid? StaffGuid { get; set; }

        public int? DelegationType { get; set; }
    }
}
