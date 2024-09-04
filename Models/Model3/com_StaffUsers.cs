namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StaffUsers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        public bool? UserIsDefault { get; set; }

        public bool? StaffIsDefault { get; set; }

        public bool? ShowInStaffTitle { get; set; }

        public int? DelegateId { get; set; }

        public bool? TransferViewAuthorities { get; set; }

        public bool? Unavailable { get; set; }
    }
}
