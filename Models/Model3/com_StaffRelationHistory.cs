namespace CustomMembershipEF.Models.Model3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_StaffRelationHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        public Guid Guid { get; set; }

        public Guid StaffGuid { get; set; }

        [Required]
        [StringLength(256)]
        public string StaffTitle { get; set; }

        public int StaffPersonRelationType { get; set; }

        public int EventType { get; set; }

        public Guid RegistrarUserGuid { get; set; }

        public Guid? ModificationServerGuid { get; set; }

        public DateTime? ModificationDate { get; set; }
    }
}
